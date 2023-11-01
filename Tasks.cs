using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{

        public class Tasks : INotifyPropertyChanged
        {
            private string taskName;
            private string status;
            private string colorText;

            public string TaskName
            {
                get => taskName; set
                {
                    taskName = value;
                    this.OnPropertyChanged("TaskName");
                }
            }

            public string Status
            {
                get => status; set
                {
                    status = value;
                    this.OnPropertyChanged(nameof(Status));
                }
            }
            public string ColorText
            {
                get => colorText; set
                {
                    colorText = value;
                    this.OnPropertyChanged(nameof(ColorText));
                }
            }

            public Tasks()
            {
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged(string propName)
            {
                this.PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propName));
            }

            //protected void OnPropertyChanged([CallerMemberName] string propName = null)
            //{
            //    PropertyChanged?.Invoke(this,
            //         new PropertyChangedEventArgs(propName));
            //}
        }
    }