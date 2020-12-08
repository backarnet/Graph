using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public class SimpleGraph
    {

        private List<Vertex> Vertices = new List<Vertex>();
        private List<Rectangle> safeArea = new List<Rectangle>();
        private const int SafeDimension = 128;
        private const int vertexDimension = 32;
        public bool autoPosition;
        public bool circularPosition;

        public SimpleGraph(Vertex v1)
        {
            Vertices.Add(v1);
        }
        public SimpleGraph(SquareMatrix matrix)
        {
            if (matrix.IsSymmetric())
            {
                for (int i = 0; i < matrix.Dimension; i++)
                {
                    Vertex v = new Vertex(matrix.Titles[i]);
                    Vertices.Add(v);
                }
                for (int i = 0; i < matrix.Dimension; i++)
                {
                    for (int j = i; j < matrix.Dimension; j++)
                    {
                        if (matrix.Matrix[i][j] != "0")
                        {
                            if (i == j)
                            {
                                throw new Exception("In simple graph, Vertex must not be connected to itself!");
                            }
                            AddEdge(Vertices[i], Vertices[j]);
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Given matrix is not symmetric!");
            }
        }

        public void AddVertex(Vertex vertex)
        {
            if (!HasVertex(vertex))
            {
                Vertices.Add(vertex);
            }
            else
            {
                throw new Exception("Vertex already add!");
            }
        }
        public bool HasVertex(Vertex vertex)
        {
            return Vertices.Contains(vertex);
        }
        public void DeleteVertex(Vertex vertex)
        {
            if (HasVertex(vertex))
            {
                foreach (var v in Vertices)
                {
                    v.Edgs.Remove(vertex);
                }
                Vertices.Remove(vertex);
            }
            else
            {
                throw new Exception("Vertex not found!");
            }
        }
        public void AddEdge(Vertex v1, Vertex v2)
        {
            if (!HasVertex(v1))
            {
                AddVertex(v1);
            }
            if (!HasVertex(v2))
            {
                AddVertex(v2);
            }
            v1.AddEdge(v2);
        }
        public void DeleteEdge(Vertex v1, Vertex v2)
        {
            v1.DeleteEdge(v2);
        }
        public int  TotalVertexDegrees()
        {
            int sum = 0;
            foreach (var ver in Vertices)
            {
                sum += ver.GetDegree();
            }
            return sum;
        }
        public int  GetOrder()
        {
            return Vertices.Count;
        }
        public int  GetSize()
        {
            return TotalVertexDegrees() / 2;
        }
        public string GenerateAdjacencyMatrix()
        {
            string matrix = "\t";
            foreach (var ver in Vertices)
            {
                matrix += ver.value + "\t";
            }
            matrix += "\r\n";
            foreach (var ver in Vertices)
            {
                matrix += ver.value + "\t";
                foreach (var vertex in Vertices)
                {
                    if (ver.Edgs.Contains(vertex))
                    {
                        matrix += "1\t";
                    }
                    else
                    {
                        matrix += "0\t";
                    }
                }
                matrix += "\r\n";
            }

            return matrix;
        }
        public List<Vertex> GetGraphicalList()
        {
            return Vertices.OrderByDescending(v => v.GetDegree()).ToList();
        }
        public string GetGraphicalSeries()
        {
            string series = "[ ";
            List<Vertex> vertices = GetGraphicalList();
            foreach (var v in vertices)
            {
                series += v.GetDegree() + " ";
            }
            return series + "]";
        }
        public string GetInfo()
        {
            string info = "Order = " + GetOrder();
            info += "\r\nSize = " + GetSize();
            info += "\r\nGraphical Series = " + GetGraphicalSeries();
            return info;
        }
        private bool IsSafeArea(Point pos)
        {
            foreach (var area in safeArea)
            {
                if (area.Contains(pos))
                {
                    return true;
                }
            }
            return false;
        }
        private void CalcPositions(int width, int height)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            Circle circle = new Circle(new Point(width / 2, height / 2), height / 2 - 50);
            List<Point> corners = circle.getCorners(Vertices.Count);
            int counter = 0;
            foreach (var v in Vertices)
            {
                Point pos = new Point(random.Next(vertexDimension, width) - vertexDimension, random.Next(vertexDimension, height) - vertexDimension);
                int i = 0;
                if (autoPosition)
                {
                    while (IsSafeArea(pos))
                    {
                        pos = new Point(random.Next(vertexDimension, width) - vertexDimension, random.Next(vertexDimension, height) - vertexDimension);
                        i++;
                        if (i > 100)
                        {
                            MessageBox.Show("Time out! increase draw box or decease safe area.");
                            return;
                        }
                    }
                    v.position = pos;
                }
                else if (circularPosition)
                {
                    v.position = corners[counter++];
                }
                safeArea.Add(new Rectangle(pos.X - SafeDimension / 2, pos.Y - SafeDimension / 2, SafeDimension, SafeDimension));
            }
        }

        public void Draw(PictureBox canvas, bool dragging)
        {
            Bitmap bitmap = new Bitmap(canvas.Width, canvas.Height);
            Graphics e = Graphics.FromImage(bitmap);
            e.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            if (!dragging)
            {
                CalcPositions(canvas.Width, canvas.Height);
            }
            foreach (var v in Vertices)
            {
                foreach (var edge in v.Edgs)
                {
                    Pen edgePen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 3);
                    
                    e.DrawCurve(edgePen,
                        GetCurvePoints(
                            new Point(
                                v.position.X + vertexDimension / 2,
                                v.position.Y + vertexDimension / 2),
                            new Point(
                                edge.position.X + vertexDimension / 2,
                                edge.position.Y + vertexDimension / 2)
                            )
                        );

                }
            }
            safeArea.Clear();
            foreach (var v in Vertices)
            {
                SolidBrush vertexBrush = new SolidBrush(Color.White);
                e.FillEllipse(vertexBrush,
                    v.position.X,
                    v.position.Y,
                    vertexDimension,
                    vertexDimension);
                Pen vertexPen = new Pen(Color.Red);
                e.DrawEllipse(vertexPen,
                    v.position.X,
                    v.position.Y,
                    vertexDimension,
                    vertexDimension);
                SolidBrush fontBrush = new SolidBrush(Color.Blue);
                Font font = new Font(FontFamily.GenericSerif, 11);
                e.DrawString(v.value, font, fontBrush, v.position.X + 7, v.position.Y + 7);
                safeArea.Add(new Rectangle(v.position.X - SafeDimension / 2, v.position.Y - SafeDimension / 2, SafeDimension, SafeDimension));
            }
            canvas.Image = bitmap;
        }

        public Vertex GetVertexByPosition(Point pointer)
        {
            for (int i = 0; i < safeArea.Count; i++)
            {
                if (safeArea[i].Contains(pointer))
                {
                    return Vertices[i];
                }
            }
            return null;
        }
        public Vertex GetVertexByValue(string value)
        {
            return Vertices.Where(v => v.value == value).First();
        }

        private string PrintList(IEnumerable<Vertex> list)
        {
            IEnumerable<Vertex> newList;
            string str = "";
            if (list is Stack<Vertex>)
            {
                newList = list.Reverse();
            }
            else
            {
                newList = list;
            }
            foreach (var v in newList)
            {
                str += v.value + " ";
            }
            return (str == ""? "-" : str);
        }

        public string DFSColoring(PictureBox canvas, Color color)
        {
            Stack<Vertex> stack = new Stack<Vertex>(GetOrder());
            Pen pen = new Pen(color, 3);
            SolidBrush brush = new SolidBrush(color);
            Font font = new Font(FontFamily.GenericSerif, 11);
            Graphics e = canvas.CreateGraphics();
            string DFSTable = "=========================\r\nDFS Table\r\n============" +
                "=============\r\n\tEvents\t|\tStack\r\n=========================\r\n";
            int sleep = 1000;


            Vertex current = Vertices[0];

            brush.Color = color;
            e.FillEllipse(brush, current.position.X, current.position.Y, vertexDimension, vertexDimension);
            brush.Color = Color.White;
            e.DrawString(current.value, font, brush, current.position.X + 7, current.position.Y + 7);

            stack.Push(current);
            current.visited = true;
            DFSTable += $"\tvis {current.value}\t|\t{PrintList(stack)}\r\n";
            Thread.Sleep(sleep);

            while (stack.Count > 0)
            {
                current = stack.Peek();

                if (stack.Peek().GetNotVisitedVertices().Count > 0)
                {

                    Vertex next = stack.Peek().GetNotVisitedVertices().First();

                    e.DrawCurve(pen,
                        GetCurvePoints(
                            new Point(
                                current.position.X + vertexDimension / 2,
                                current.position.Y + vertexDimension / 2),
                            new Point(
                                next.position.X + vertexDimension / 2,
                                next.position.Y + vertexDimension / 2)
                            )
                        );
                    Thread.Sleep(sleep);

                    brush.Color = color;
                    e.FillEllipse(brush,
                        next.position.X,
                        next.position.Y,
                        vertexDimension,
                        vertexDimension);

                    brush.Color = Color.White;
                    e.DrawString(
                        next.value,
                        font,
                        brush,
                        next.position.X + 7,
                        next.position.Y + 7);

                    stack.Push(next);
                    next.visited = true;
                    DFSTable += $"\tvis {next.value}\t|\t{PrintList(stack)}\r\n";
                    Thread.Sleep(sleep);
                }
                else
                {
                    stack.Pop();
                    DFSTable += $"\trmv {current.value}\t|\t{PrintList(stack)}\r\n";
                }
            }
            ZeroVisited();
            Thread.Sleep(sleep);
            return DFSTable;
        }

        public string BFSColoring(PictureBox canvas, Color color)
        {
            Queue<Vertex> queue = new Queue<Vertex>(GetOrder());
            Pen pen = new Pen(color, 3);
            SolidBrush brush = new SolidBrush(color);
            Font font = new Font(FontFamily.GenericSerif, 11);
            Graphics e = canvas.CreateGraphics();

            string BFSTable = "=========================================\r\nBFS Table\r\n=====================" +
                "=============\r\n\tEvents\t|\tCurrent\t|\tQueue\r\n==================================\r\n";
            int sleep = 1000;

            Vertex current = Vertices[0];

            brush.Color = color;
            e.FillEllipse(brush, current.position.X, current.position.Y, vertexDimension, vertexDimension);
            brush.Color = Color.White;
            e.DrawString(current.value, font, brush, current.position.X + 7, current.position.Y + 7);

            current.visited = true;
            BFSTable += $"\tvis {current.value}\t|\tvis {current.value}\t|\t{PrintList(queue)}\r\n";

            while (queue.Count > 0 || current.GetNotVisitedVertices().Count > 0)
            {
                if (current.GetNotVisitedVertices().Count > 0)
                {
                    foreach (var next in current.GetNotVisitedVertices())
                    {

                        e.DrawCurve(pen,
                            GetCurvePoints(
                                new Point(
                                    current.position.X + vertexDimension / 2,
                                    current.position.Y + vertexDimension / 2),
                                new Point(
                                    next.position.X + vertexDimension / 2,
                                    next.position.Y + vertexDimension / 2)
                                )
                            );
                        Thread.Sleep(sleep);

                        brush.Color = color;
                        e.FillEllipse(brush,
                            next.position.X,
                            next.position.Y,
                            vertexDimension,
                            vertexDimension);

                        brush.Color = Color.White;
                        e.DrawString(
                            next.value,
                            font,
                            brush,
                            next.position.X + 7,
                            next.position.Y + 7);

                        queue.Enqueue(next);
                        next.visited = true;
                        BFSTable += $"\tvis {next.value}\t|\tvis {current.value}\t|\t{PrintList(queue)}\r\n";
                        Thread.Sleep(sleep);
                    }
                }
                else
                {
                    current = queue.Dequeue();
                    BFSTable += $"\trmv {current.value}\t|\tvis {current.value}\t|\t{PrintList(queue)}\r\n";
                }
            }
            ZeroVisited();
            Thread.Sleep(sleep);
            return BFSTable;
        }

        private Point[] GetCurvePoints(Point start, Point end)
        {
            int cX = (end.X + start.X) / 2; //  + 100;
            int cY = (end.Y + start.Y) / 2; //  + 100;
            Point center = new Point(cX, cY);
            Point[] points = { start, center, end};
            return points;
        }

        public void ZeroVisited()
        {
            foreach (var v in Vertices)
            {
                v.visited = false;
            }
        }

    }
}
