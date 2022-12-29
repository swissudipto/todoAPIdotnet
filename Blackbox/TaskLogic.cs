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
        int maxtaskcount=getmaxtasknumber();
        Tasktable newtaskobj=new Tasktable(){
            Tasknumber=maxtaskcount+1,
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
            context.SaveChanges();

        }

        public List<Tasktable> gettask()
        {
            var context=new MasterContext();

            List<Tasktable> tasklist=new List<Tasktable>();
            tasklist=context.Tasktables.ToList<Tasktable>();

            return tasklist;
        }
        public int getmaxtasknumber()
        {
            var context=new MasterContext();
           
            //return context.Tasktables.Select(p => p.Tasknumber).DefaultIfEmpty(0).Max();
            return context.Tasktables.Max(p => (int?)p.Tasknumber) ?? 0; 
        }
    }
}