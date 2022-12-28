using todoAPIdotnet.Models;

namespace todoAPIdotnet.Interfaces
{
    public interface ITasklogic
    {

        public List<Tasktable> gettask();
        public void addtask(Tasktable newtask);
        public void deletetask(Tasktable tasktobeleted);

    }
}