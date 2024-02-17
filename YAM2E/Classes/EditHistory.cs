using LAMP.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes;

public class EditHistory
{
    //Fields
    private Stack<Action> UndoStack = new();
    private Stack<Action> RedoStack = new();

    public event System.EventHandler AddedAction;
    public event System.EventHandler UndoRedo;

    public bool canUndo => UndoStack.Count > 0;
    public bool canRedo => RedoStack.Count > 0;

    public void Undo()
    {
        if (!canUndo) return;

        Action last = UndoStack.Pop();
        last.Undo();
        RedoStack.Push(last);

        UndoRedo?.Invoke(this, new System.EventArgs());
    }

    public void Redo()
    {
        if (!canRedo) return;

        Action last = RedoStack.Pop();
        last.Do();
        UndoStack.Push(last);

        UndoRedo?.Invoke(this, new System.EventArgs());
    }

    public void AddActionToHistory(Action action)
    {
        UndoStack.Push(action);
        RedoStack.Clear();
        AddedAction?.Invoke(this, new System.EventArgs());
    }
}
