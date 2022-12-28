using Microsoft.AspNetCore.Mvc;
using todoAPIdotnet.Interfaces;
using todoAPIdotnet.Models;


namespace todoAPIdotnet.Controllers{
    [ApiController]
    [Route("task")]
   public class TaskController:ControllerBase
   {
    public readonly ITasklogic tasklogic;
    public TaskController(ITasklogic Tasklogic)
    {
        this.tasklogic=Tasklogic;
    }
    [HttpPost]
    public  ActionResult<Tasktable> addnewtask(Tasktable newtask)
    {

        this.tasklogic.addtask(newtask);

        return CreatedAtAction(nameof(addnewtask), newtask);
    }
    [HttpGet]
    public ActionResult<List<Tasktable>> gettasks()
    {
        return this.tasklogic.gettask();
    }
    [HttpDelete]
    public ActionResult<Tasktable> deletetask(Tasktable tasktobedleted)
    {
        this.tasklogic.deletetask(tasktobedleted);

        return null;
    }

   
   
   }
}