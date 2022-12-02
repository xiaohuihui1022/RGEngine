using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace RGEngine.Dev
{
    public class NAPlayer
    {
        public double SoundProgress;

        private IWavePlayer _device;

        private ProgressBar progress;

        private Form invokedForm;

        private AudioFileReader _reader;

        private VolumeSampleProvider _volumeProvider;

        private CancellationTokenSource _cts;

        private bool _sliderLock; // 逻辑锁，当为true时不更新界面上的进度

        public void PlaySound()
        {
            PlayAction();
        }

        public void PauseSound()
        {
            PauseAction();
        }

        public void StopSound()
        {
            StopAction();
        }

        public void OpenFile(string fileName, ProgressBar progresses, Form form)
        {
            DisposeAll();
            try
            {
                progress = progresses;
                invokedForm = form;
                if (!File.Exists(fileName))
                    throw new FileNotFoundException("所选文件不存在");
                _device = new WaveOutEvent(); // Create device
                _reader = new AudioFileReader(fileName); // Create reader

                // dsp start
                _volumeProvider = new VolumeSampleProvider(_reader)
                {
                    Volume = 100f
                };

                _device.Init(_volumeProvider);
                //_device.Init(_reader); // 之前是reader，现改为VolumeSampleProvider
                // https://stackoverflow.com/questions/46433790/how-to-chain-together-multiple-naudio-isampleprovider-effects

                var duration = _reader.TotalTime; // 总时长
                progresses.Maximum = (int)duration.TotalMilliseconds;

                _cts = new CancellationTokenSource();
                StartUpdateProgress(); // 界面更新线程

                _device.PlaybackStopped += Device_OnPlaybackStopped;
            }
            catch (Exception ex)
            {
                DisposeAll();
                MessageBox.Show(ex.Message);
            }
        }

        public void Device_OnPlaybackStopped(object obj, StoppedEventArgs arg)
        {
            StopAction();
        }

        public void StartUpdateProgress()
        {
            // 此处可用Timer完成而不是手动循环，但不建议使用UI线程上的Timer
            Task.Run(() =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    if (_device.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(100);
                        // 若为播放状态，持续更新界面
                        try
                        {
                            invokedForm.BeginInvoke(new Action(UpdateProgress));
                        }
                        catch
                        {
                            continue;
                        }
                        
                    }
                    else
                    {
                        Thread.Sleep(50);
                    }
                }
            });
        }

        public void StopAction()
        {
            _device?.Stop();
            // if (_reader != null) _reader.Position = 0;
            // UpdateProgress();
        }

        public void PlayAction()
        {
            _device?.Play();
        }

        public void PauseAction()
        {
            _device?.Pause();
        }

        public void UpdateProgress()
        {
            var currentTime = _reader?.CurrentTime ?? TimeSpan.Zero; // 当前时间
            // Console.WriteLine(currentTime);
            
            if (!_sliderLock)
            {
                progress.Value = (int)currentTime.TotalMilliseconds;
                SoundProgress = currentTime.TotalMilliseconds;
            }
            
        }


        public void DisposeDevice()
        {
            if (_device != null)
            {
                _device.PlaybackStopped -= Device_OnPlaybackStopped;
                _device.Dispose();
            }
        }

        public void DisposeAll()
        {
            _cts?.Cancel();
            _cts?.Dispose();
            _reader?.Dispose();
            DisposeDevice();
        }
    }
}
