using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        private SimpleGraph adjGraph;
        private bool dragging = false;
        private Vertex movingVertex;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SquareMatrix matrix = new SquareMatrix(txt_matrix.Lines, '\t');
                adjGraph = new SimpleGraph(matrix);
                adjGraph.autoPosition = rdAuto.Checked;
                adjGraph.circularPosition = rdCircular.Checked;
                txt_info.Text = adjGraph.GetInfo();
                Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Redraw()
        {
            if (adjGraph != null)
            {
                adjGraph.Draw(pictureBox1, dragging);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Redraw();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                try
                {
                    movingVertex = adjGraph.GetVertexByPosition(e.Location);
                    Text = movingVertex.value;
                    dragging = true;
                }
                catch (Exception)
                {

                }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
            movingVertex = null;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                if (adjGraph != null)
                {
                    if (movingVertex != null)
                    {
                        movingVertex.position = e.Location;
                        Redraw();
                    }
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Vertex vertex = new Vertex(txt_v.Text);
                vertex.position = new Point(Convert.ToInt32(txt_x.Text), Convert.ToInt32(txt_y.Text));
                adjGraph.AddVertex(vertex);
                txt_matrix.Text = adjGraph.GenerateAdjacencyMatrix();
                txt_info.Text = adjGraph.GetInfo();
                txt_x.Text = txt_y.Text = txt_v.Text = "";
                Redraw();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // if (txt_v1_del_edge.Text != "" && txt_v2_del_edge.Text != "")
                if(txt_v_del.Text != "")
                {
                    Vertex vertex = new Vertex(txt_v_del.Text);
                    adjGraph.DeleteVertex(vertex);
                    txt_matrix.Text = adjGraph.GenerateAdjacencyMatrix();
                    txt_info.Text = adjGraph.GetInfo();
                    txt_v_del.Text = "";
                    Redraw();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_v1_add_edge.Text != "" && txt_v2_add_edge.Text != "")
                {
                    Vertex v1 = adjGraph.GetVertexByValue(txt_v1_add_edge.Text);
                    Vertex v2 = adjGraph.GetVertexByValue(txt_v2_add_edge.Text);
                    adjGraph.AddEdge(v1, v2);
                    txt_matrix.Text = adjGraph.GenerateAdjacencyMatrix();
                    txt_info.Text = adjGraph.GetInfo();
                    txt_v1_add_edge.Text = "";
                    txt_v2_add_edge.Text = "";
                    Redraw();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_v1_del_edge.Text != "" && txt_v2_del_edge.Text != "")
                {
                    Vertex v1 = adjGraph.GetVertexByValue(txt_v1_del_edge.Text);
                    Vertex v2 = adjGraph.GetVertexByValue(txt_v2_del_edge.Text);
                    adjGraph.DeleteEdge(v1, v2);
                    txt_matrix.Text = adjGraph.GenerateAdjacencyMatrix();
                    txt_info.Text = adjGraph.GetInfo();
                    txt_v1_del_edge.Text = "";
                    txt_v2_del_edge.Text = "";
                    Redraw();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (adjGraph != null)
        //    {
        //        adjGraph.autoPosition = checkBox1.Checked;
        //    }
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            txt_info.Text += "\r\n" + adjGraph.DFSColoring(pictureBox1, Color.Red);
            Cursor = Cursors.Default;
            Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Enabled = false;
            txt_info.Text += "\r\n" + adjGraph.BFSColoring(pictureBox1, Color.Red);
            Cursor = Cursors.Default;
            Enabled = true;
        }

        private void rdAuto_CheckedChanged(object sender, EventArgs e)
        {
            adjGraph.autoPosition = rdAuto.Checked;
            adjGraph.circularPosition = rdCircular.Checked;
        }
    }
}
