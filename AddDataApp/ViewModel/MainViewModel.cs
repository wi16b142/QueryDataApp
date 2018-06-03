using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
//using System.Messaging; //add reference to Messaging
using System.Runtime.Serialization; //add reference to Serialization
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using AddDataApp.Model;
using Shared;
using MqHandling;

namespace AddDataApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        MqHandler<XData> mq = new MqHandler<XData>("SycoMq");
        SR_Core.ServiceCoreClient client = new SR_Core.ServiceCoreClient();
        private string _target="";
        private string _name = "";
        private string _type = "";
        private string _salary = "";
        private bool _ownskey = false;
        private string[] _types;
        private string[] _targets;

        public RelayCommand SendBtnClick { get; set; }

        #region Properties
        public string Target
        {
            get => _target; set
            {
                _target = value; RaisePropertyChanged();
            }
        }
        public string Name
        {
            get => _name; set
            {
                _name = value; RaisePropertyChanged();
            }
        }
        public string Type
        {
            get => _type; set
            {
                _type = value; RaisePropertyChanged();
            }
        }
        public string Salary
        {
            get => _salary; set
            {
                _salary = value; RaisePropertyChanged();
            }
        }
        public bool Ownskey
        {
            get => _ownskey; set
            {
                _ownskey = value; RaisePropertyChanged();
            }
        }
        public string[] Types
        {
            get => _types; set
            {
                _types = value; RaisePropertyChanged();
            }
        }
        public string[] Targets
        {
            get => _targets; set
            {
                _targets = value; RaisePropertyChanged();
            }
        }
#endregion

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
                Types = client.GetAvailableTypes();
                Targets = client.GetAvailableRepos();

                SendBtnClick = new RelayCommand(() =>
                {
                    XData temp = new XData(
                        Name,
                        Type,
                        Decimal.Parse(Salary),
                        Ownskey,
                        Guid.NewGuid(),
                        Target
                    );
                    mq.Send(temp);
                }, () =>
                 {
                     if (!Name.Equals("") && !Type.Equals("") && !Salary.Equals("") && !Target.Equals("") && Decimal.TryParse(Salary, out decimal result)) return true;
                     return false;
                 });

            }
        }
    }
}

































































#region 
/*
public class MqHandler<T>
{
    private string connectionString = @"FormatName:direct=os:";
    private string mqPrefix = @".\private$\";
    private string mqName;
    private MessageQueue mq;

    public MqHandler(string mqName)
    {
        this.mqName = mqName;
        if (!MessageQueue.Exists(mqPrefix + mqName))
        {
            MessageQueue.Create(mqPrefix + mqName);
        }
        mq = new MessageQueue(connectionString + mqPrefix + mqName);
        mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
    }

    public void Send(T t)
    {
        mq.Send(t);
    }

    public T Receive()
    {
        return (T)mq.Receive().Body;
    }
}

-------------------------------SQL


    public List<XTask> QueryTasksByDuration(int duration)
    {
        return db.Task.Where(x => x.Duration > duration).Select(x => new XTask()
        {
            Id = x.Id,
            Description = x.Description,
            Duration = (int)x.Duration,
            Priority = (int)x.Priority
        }).ToList();
    }

    public List<XTask> QueryTasksByDurationAndPriority(int duration, int priority)
    {
        return db.Task.Where(x => (x.Duration > duration && x.Priority > priority)).Select(x => new XTask()
        {
            Id = x.Id,
            Description = x.Description,
            Duration = (int)x.Duration,
            Priority = (int)x.Priority
        }).ToList();
    }

    public List<XTask> QueryTasksByTypDescription(string description)
    {
        return db.Task.Where(x => x.Type.Description.Equals(description)).Select(x => new XTask()
        {
            Id = x.Id,
            Description = x.Description,
            Duration = (int)x.Duration,
            Priority = (int)x.Priority
        }).ToList();
    }

    public void AddNewTaskAndType(XTask task, XType type)
    {
        Guid temp = Guid.NewGuid();
        db.Task.Add(new Task()
        {
            Id = Guid.NewGuid(),
            Description = task.Description,
            Duration = task.Duration,
            Priority = task.Priority,
            FK_Type = temp
        });

        db.Type.Add(new Type()
        {
            Id = temp,
            Description = type.Description
        });
        db.SaveChanges();
    }

    public void AddNewTaskByTypeId(XTask task, Guid typeId)
    {
        db.Task.Add(new Task()
        {
            Id = Guid.NewGuid(),
            Description = task.Description,
            Duration = task.Duration,
            Priority = task.Priority,
            FK_Type = typeId
        });
        db.SaveChanges();
    }

    public void AddNewTaskByTypeDescription(XTask task, string typeDescription)
    {
        db.Task.Add(new Task()
        {
            Id = Guid.NewGuid(),
            Description = task.Description,
            Duration = task.Duration,
            Priority = task.Priority,
            FK_Type = (Guid)db.Type.SingleOrDefault(x => x.Description.Equals(typeDescription, StringComparison.InvariantCultureIgnoreCase)).Id
        });
        db.SaveChanges();
    }

    -----------------------misc
    dispatcherTimer = new DispatcherTimer();
    dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
    dispatcherTimer.Interval = new TimeSpan(0,0,1); //h,m,s
    dispatcherTimer.Start();
    private void dispatcherTimer_Tick(object sender, EventArgs e)
    {
        //...DoWork
        //e.Reult=...
    }
*/
#endregion