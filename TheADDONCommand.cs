using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G1ANT.Language;

namespace G1ANT.Addon.MyAddon
{
    [Command(Name ="mycommand", Tooltip = "This is a demo command.")]
    class MyCommand : Command
    {
        public MyCommand(AbstractScripter scripter) : base(scripter)
        {

        }
        public class Arguments : CommandArguments
        {
            [Argument(Name = "message", Required = true, Tooltip = "Type in the text to display")]
            public TextStructure message { get; set; } = new TextStructure();

        }
        public void Execute(Arguments arguments)
        {
            RobotMessageBox.Show(arguments.message.Value);
        }
    }
}
