﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: .NET Core 3.1.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Blowdart.UI.Blazor
{
    partial class ImGui
    {
        #region Mouse

        public EventCallback<MouseEventArgs> OnClick(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnClick, null);
            });
        }

        public EventCallback<MouseEventArgs> OnDoubleClick(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnDoubleClick, null);
            });
        }

        public EventCallback<MouseEventArgs> OnMouseDown(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnMouseDown, null);
            });
        }

        public EventCallback<MouseEventArgs> OnMouseMove(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnMouseMove, null);
            });
        }

        public EventCallback<MouseEventArgs> OnMouseOut(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnMouseOut, null);
            });
        }

        public EventCallback<MouseEventArgs> OnMouseOver(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnMouseOver, null);
            });
        }

        public EventCallback<MouseEventArgs> OnMouseUp(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnMouseUp, null);
            });
        }

        public EventCallback<MouseEventArgs> OnWheel(Value128 id)
        {
            return EventCallback.Factory.Create<MouseEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Mouse.OnWheel, null);
            });
        }

        #endregion

        #region Clipboard

        public EventCallback<ClipboardEventArgs> OnCopy(Value128 id)
        {
            return EventCallback.Factory.Create<ClipboardEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Clipboard.OnCopy, null);
            });
        }

        public EventCallback<ClipboardEventArgs> OnCut(Value128 id)
        {
            return EventCallback.Factory.Create<ClipboardEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Clipboard.OnCut, null);
            });
        }

        public EventCallback<ClipboardEventArgs> OnPaste(Value128 id)
        {
            return EventCallback.Factory.Create<ClipboardEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Clipboard.OnPaste, null);
            });
        }

        #endregion

        #region Drag

        public EventCallback<DragEventArgs> OnDrag(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDrag, null);
            });
        }

        public EventCallback<DragEventArgs> OnDragEnd(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDragEnd, null);
            });
        }

        public EventCallback<DragEventArgs> OnDragEnter(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDragEnter, null);
            });
        }

        public EventCallback<DragEventArgs> OnDragLeave(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDragLeave, null);
            });
        }

        public EventCallback<DragEventArgs> OnDragOver(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDragOver, null);
            });
        }

        public EventCallback<DragEventArgs> OnDragStart(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDragStart, null);
            });
        }

        public EventCallback<DragEventArgs> OnDrop(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnDrop, null);
            });
        }

        public EventCallback<DragEventArgs> OnScroll(Value128 id)
        {
            return EventCallback.Factory.Create<DragEventArgs>(this, args =>
            {
                OnEvent(id, HtmlEvents.Drag.OnScroll, null);
            });
        }

        #endregion
    }
}

