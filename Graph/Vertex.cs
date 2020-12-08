using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Vertex
    {
        public string value { get; set; }

        public List<Vertex> Edgs { get; set; } = new List<Vertex>();

        public Point position { get; set; }

        public bool visited;

        public Vertex(string value)
        {
            this.value = value;
        }
        public bool HasEdge(Vertex vertex)
        {
            return Edgs.Contains(vertex);
        }

        public void AddEdge(Vertex vertex)
        {
            if (!HasEdge(vertex) && !vertex.HasEdge(this))
            {
                Edgs.Add(vertex);
                vertex.Edgs.Add(this);
            }
            else
            {
                throw new Exception("Edge already added!");
            }
        }

        public void DeleteEdge(Vertex vertex)
        {
            if (HasEdge(vertex) || vertex.HasEdge(this))
            {
                Edgs.Remove(vertex);
                vertex.Edgs.Remove(this);
            }
            else
            {
                throw new Exception("Edge not found!");
            }
        }

        public int GetDegree()
        {
            return Edgs.Count();
        }

        public List<Vertex> GetNotVisitedVertices()
        {
            return Edgs.Where(v => v.visited == false).ToList();
        }

        public override bool Equals(object obj)
        {
            return value == (obj as Vertex).value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}
