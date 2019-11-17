// Copyright (c) Daniel Crenna & Contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Blowdart.UI.Instructions;

namespace Blowdart.UI
{
    public partial class Ui
	{
		#region Ids

		private readonly Stack<Value128> _ids = new Stack<Value128>();
		
		public Value128 PushId(Value128 id)
		{
			_ids.Push(id);
			return id;
		}

		public bool TryPopId(out Value128 id)
		{
			if (_ids.Count > 0)
			{
				id = _ids.Pop();
				return true;
			}

			id = default;
			return false;
		}
        
		public Value128 PopId()
		{
			return _ids.Pop();
		}

		internal Value128 ResolveId()
		{
			return NextId();
			// return TryPopId(out var id) ? id : NextId();
		}

		#endregion

		#region Options

		private readonly Stack<ElementAlignment> _alignments = new Stack<ElementAlignment>();
		private readonly Stack<ElementContext> _contexts = new Stack<ElementContext>();
		private readonly Stack<ElementDecorator> _decorators = new Stack<ElementDecorator>();
		private readonly Stack<ElementSize> _sizes = new Stack<ElementSize>();
		private readonly Stack<ElementStyle> _styles = new Stack<ElementStyle>();

		private readonly Stack<InputActivation> _activations = new Stack<InputActivation>();
		private readonly Stack<FieldType> _fieldTypes = new Stack<FieldType>();
		private readonly Stack<OpenIconicIcons> _icons = new Stack<OpenIconicIcons>();

		public ElementContext Push(ElementContext context)
		{
			_contexts.Push(context);
			return context;
		}

		public InputActivation Push(InputActivation activation)
		{
			_activations.Push(activation);
			return activation;
		}

		public ElementAlignment Push(ElementAlignment alignment)
		{
			_alignments.Push(alignment);
			return alignment;
		}

		public ElementStyle Push(ElementStyle style)
		{
			_styles.Push(style);
			return style;
		}

		public OpenIconicIcons Push(OpenIconicIcons icon)
		{
			_icons.Push(icon);
			return icon;
		}

		public ElementSize Push(ElementSize size)
		{
			_sizes.Push(size);
			return size;
		}

		public ElementDecorator Push(ElementDecorator decorator)
		{
			_decorators.Push(decorator);
			return decorator;
		}
		
		public FieldType Push(FieldType type)
		{
			_fieldTypes.Push(type);
			return type;
		}

		internal bool TryPop<T>(out T option)
		{
			if (typeof(T) == typeof(ElementAlignment))
			{
				if (_alignments.Count > 0)
				{
					option = (T) (object) _alignments.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(ElementContext))
			{
				if (_contexts.Count > 0)
				{
					option = (T) (object) _contexts.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(ElementSize))
			{
				if (_sizes.Count > 0)
				{
					option = (T) (object) _sizes.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(InputActivation))
			{
				if (_activations.Count > 0)
				{
					option = (T) (object) _activations.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(ElementDecorator))
			{
				if (_decorators.Count > 0)
				{
					option = (T) (object) _decorators.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(ElementStyle))
			{
				if (_styles.Count > 0)
				{
					option = (T) (object) _styles.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(OpenIconicIcons))
			{
				if (_icons.Count > 0)
				{
					option = (T) (object) _icons.Pop();
					return true;
				}
			}

			if (typeof(T) == typeof(FieldType))
			{
				if (_fieldTypes.Count > 0)
				{
					option = (T) (object) _fieldTypes.Pop();
					return true;
				}
			}

			option = default;
			return false;
		}
		
		#endregion

		#region Tables

		private bool _inTable;
		
		public void NextColumn()
		{
			if (!_inTable)
				throw new BlowdartException($"{nameof(NextColumn)} was called outside of a table");
			Instructions.Add(new EndElementInstruction(ElementType.TableColumn));
			Instructions.Add(new BeginElementInstruction(ElementType.TableColumn));
		}

		public void NextColumn(ref int ordinal)
		{
            if(!_inTable)
                throw new BlowdartException($"{nameof(NextColumn)} was called outside of a table");
			Instructions.Add(new EndElementInstruction(ElementType.TableColumn));
			Instructions.Add(new BeginElementInstruction(ElementType.TableColumn, ordinal: ++ordinal));
		}

		#endregion

		#region Menus

		private bool _inMenu;
		private bool _hasMenuItems;

		public void MenuItem(OpenIconicIcons icon, string title, string template)
		{
			if (!_inMenu)
				throw new BlowdartException($"{nameof(MenuItem)} was called outside of a menu");

			if (!_hasMenuItems)
			{
				Instructions.Add(new BeginMenuInstruction());
				_hasMenuItems = true;
			}

			Instructions.Add(new MenuItemInstruction(icon, template, title));
		}

		#endregion

		public void ShowModal(string title)
		{
			var id = HashId($"modal:{title}");
			Instructions.Add(new ShowModalInstruction(id));
		}

		public void ShowCollapsible(string title)
		{
			var id = HashId($"collapse:{title}");
			Instructions.Add(new ShowCollapsibleInstruction(id));
		}
	}
}

