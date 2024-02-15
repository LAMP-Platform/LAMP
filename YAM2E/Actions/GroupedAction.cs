using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAMP.Interfaces;

namespace LAMP.Actions;

internal class GroupedAction : Action
{
    public List<Action> Actions = new List<Action>();

    public void Do()
    {
        foreach (Action action in Actions) { action.Do(); }
    }

    public void Undo()
    {
        Actions.Reverse();
        foreach (Action action in Actions) { action.Undo(); }
        Actions.Reverse();
    }
}
