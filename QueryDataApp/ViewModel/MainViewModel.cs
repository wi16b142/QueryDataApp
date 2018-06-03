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
using QueryDataApp.Model;

namespace QueryDataApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //private Service_Client client = new Service_Client("tcp");

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                // Code runs "for real"
                //Task.Factory.StartNew(Refresh); //when GUI refreshes in own thread.
            }

            /*
            private void Refresh()
            {
                while (true)
                {
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        //DoWork
                        //RaisePropertyChanged("PropThatHasChanged");
                    });
                    //Thread.Sleep(4000);
                }
            }
            */
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