using GalaSoft.MvvmLight;
using Shared;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace QueryDataApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private SR_Core.ServiceCoreClient client = new SR_Core.ServiceCoreClient();
        private ObservableCollection<XData> data;
        private string source="";
        private string[] sources;

        #region Properties
        public string[] Sources
        {
            get => sources; set
            {
                sources = value; RaisePropertyChanged();
            }
        }

        public string Source
        {
            get { return source; }
            set { source = value; RaisePropertyChanged(); }
        }


        public ObservableCollection<XData> Data
        {
            get { return data; }
            set { data = value; RaisePropertyChanged(); }
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
                Sources = client.GetAvailableRepos();
                Data = new ObservableCollection<XData>(client.GetDataFromRepo(Source));
                Task.Factory.StartNew(Refresh); //when GUI refreshes in own thread.
            }
        }

        private void Refresh()
        {
            while (true)
            {
                App.Current.Dispatcher.Invoke(() =>
                {
                    Data = null;
                    Data = new ObservableCollection<XData>(client.GetDataFromRepo(Source));
                    RaisePropertyChanged("Data");
                });
                Thread.Sleep(5000);
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