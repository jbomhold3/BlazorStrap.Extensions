using System;
using System.Collections.Generic;
using System.Linq;
#nullable enable
namespace BlazorStrap.Extensions.Components
{
    public class BSNavbarBuilder
    {
        private List<BSNavbarItemsList> _navbarItems { get; set; } = new List<BSNavbarItemsList>();
        public List<BSNavbarItemsList> GetItems { get { return _navbarItems; } }
        private Guid _lastSetId { get; set; }
        private List<Guid> _lastId { get; set; } = new List<Guid>();
        public BSNavbarBuilder()
        {
            var item = new BSNavbarItemsList();
            _navbarItems.Add(item);
            _lastId.Add(item.Id);
        }
        public BSNavbarBuilder AddItem(string Label = "", string Icon = "", string Link = "", bool External = false, bool IconToRight = false, bool IconOnly = false)
        {
            var item = new BSNavbarItemsList()
            {
                Label = Label,
                Icon = Icon,
                Link = Link,
                External = External,
                IconToRight = IconToRight,
                IconOnly = IconOnly,
                Children = new List<BSNavbarItemsList>()
            };
            var parent = _navbarItems.First(q => q.Id == _lastId[_lastId.Count - 1]);
            parent.Children.Add(item);
            return this;
        }

        public BSNavbarBuilder StartSubMenu()
        {
            _lastId.Add(_lastSetId);
            return this;
        }
        public BSNavbarBuilder EndSubMenu()
        {
            _lastId.Remove(_lastId[_lastId.Count - 1]);
            return this;
        }
    }
    public class BSNavbarItemsList
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Label { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public bool External  { get; set; }
        public bool IconToRight { get; set; }
        public bool IconOnly { get; set; }
        public List<BSNavbarItemsList> Children { get; set; }
    }
}
