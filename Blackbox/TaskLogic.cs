using todoAPIdotnet.Models;
using todoAPIdotnet.Interfaces;

namespace todoAPIdotnet.Blackbox{
public class TaskLogic : ITasklogic
{
    /* public List<Tasktable> gettask()
     {
         var context=new MasterContext();
         List<Tasktable>  
         tabledata= context.Tasktables.ToList<Tasktable>;
         return tabledata;
     }*/
    public void addtask(Tasktable newtask)
    {
        var context=new MasterContext();
        Tasktable newtaskobj=new Tasktable(){
            Tasknumber=newtask.Tasknumber,
            Taskname=newtask.Taskname,
            Taskstartdate=newtask.Taskstartdate,
            Taskenddate=newtask.Taskenddate,
            Taskstatus=newtask.Taskstatus
            
        };
        context.Tasktables.Add(newtaskobj);
        context.SaveChanges();

    }

        public void deletetask(Tasktable tasktobeleted)
        {
            var context=new MasterContext();
            context.Tasktables.Remove(tasktobeleted);

        }

        public List<Tasktable> gettask()
        {
            var context=new MasterContext();

            List<Tasktable> tasklist=new List<Tasktable>();
            tasklist=context.Tasktables.ToList<Tasktable>();

            return tasklist;
        }
    }
}