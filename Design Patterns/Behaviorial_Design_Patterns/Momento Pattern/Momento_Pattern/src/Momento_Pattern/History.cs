using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Momento_Pattern.src.Momento_Pattern
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void BackUp()
        {
            _states.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_states.Count == 0)
            {
                return;
            }

            EditorState prevState = _states.Last();
            _states.Remove(prevState);
            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            System.Console.WriteLine("\nHistory: Here's the list of states saved in the history");

            foreach (var state in _states)
            {
                System.Console.WriteLine(state.GetName());
            }

        }
    }
}