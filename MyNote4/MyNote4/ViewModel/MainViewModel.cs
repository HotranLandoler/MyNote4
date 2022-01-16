using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using MyNote4.Model;

namespace MyNote4.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        private bool isListPaneOpen = true;

        /// <summary>
        /// 笔记的列表
        /// </summary>
        public IList<Note> Notes { get; private set; } = new ObservableCollection<Note>();

        /// <summary>
        /// 列表是否折叠
        /// </summary>
        public bool IsListPaneOpen
        {
            get => isListPaneOpen;
            set => SetProperty(ref isListPaneOpen, value);
        }

        /// <summary>
        /// 折叠列表
        /// </summary>
        public RelayCommand FoldCommand { get; }

        public MainViewModel()
        {
            FoldCommand = new RelayCommand(DoFoldList);
            Notes.Add(new Note() { Title = "我的", Content = "uit" });
            Notes.Add(new Note() { Title = "萨达", Content = "uit" });
            Notes.Add(new Note() { Title = "的", Content = "uit" });
            Notes.Add(new Note() { Title = "我去恶趣味", Content = "uit" });
            Notes.Add(new Note() { Title = "萨达的", Content = "uit" });
        }

        private void DoFoldList()
        {
            IsListPaneOpen = !IsListPaneOpen;
        }
    }
}
