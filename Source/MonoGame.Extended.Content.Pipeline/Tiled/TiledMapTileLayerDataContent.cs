using System.Collections.Generic;
using System.Xml.Serialization;

namespace MonoGame.Extended.Content.Pipeline.Tiled
{
    public class TiledMapTileLayerDataContent
    {
        [XmlAttribute(AttributeName = "encoding")]
        public string Encoding { get; set; }

        [XmlAttribute(AttributeName = "compression")]
        public string Compression { get; set; }

        [XmlElement(ElementName = "tile")]
        public List<TiledMapTileContent> Tiles { get; set; }

		[XmlElement(ElementName = "chunk")]
		public List<TiledMapTileLayerDataChunkContent> Chunks { get; set; }

        [XmlText]
        public string Value { get; set; }

        public TiledMapTileLayerDataContent()
        {
            Tiles = new List<TiledMapTileContent>();
        }

        public override string ToString()
        {
            return $"{Encoding} {Compression}";
        }
    }
}