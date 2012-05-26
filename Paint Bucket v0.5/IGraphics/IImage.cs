using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DejaVu;
using DejaVu.Collections.Generic;

namespace VisualBounds.Imaging.PaintBucket.IGraphics
{
    public class IImage
    {
        public UndoRedoArea Manager;

        private UndoRedo<string> _Name = new UndoRedo<string>();
        /// <summary>
        /// Gets the value indicating the IImage Name.
        /// </summary>
        public string Name
        {
            get { return _Name.Value; }
            private set { _Name.Value = value; }
        }

        private UndoRedoList<ILayer> _Layers = new UndoRedoList<ILayer>();
        public UndoRedoList<ILayer> Layers
        {
            get { return _Layers; }
            set { _Layers = value; }
        }

        private UndoRedo<int> _SelectedLayer = new UndoRedo<int>();
        /// <summary>
        /// Gets the value indicating the SelectedLayer ID.
        /// </summary>
        public int SelectedLayer
        {
            get { return _SelectedLayer.Value; }
            private set { _SelectedLayer.Value = value; }
        }

        public IImage()
        {
            Manager = new UndoRedoArea("IImage");
        }

        /// <summary>
        /// Select a specific layer from the layers list.
        /// </summary>
        /// <param name="layer">ID of the layer to select.</param>
        public void SelectLayer(int layer)
        {
            using (Manager.Start("Select Layer"))
            {
                SelectedLayer = layer;
                Manager.Commit();
            }
        }

        public void SetName(string name)
        {
            using (Manager.Start("Set Image Name"))
            {
                Name = name;
                Manager.Commit();
            }
        }
    }
}
