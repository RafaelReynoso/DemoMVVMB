using DemoMVVMB.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVMB.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set
            {

                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<TaskModel> tasks;
        public ObservableCollection<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public TaskViewModel()
        {
            ObservableCollection<TaskModel> TaskModels = new ObservableCollection<TaskModel>();
            Save = new Command(() =>
            {
                TaskModels.Add(new TaskModel(Title, Status, Description));
            });

            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }
    }
}
