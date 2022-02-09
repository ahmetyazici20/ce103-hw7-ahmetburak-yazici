using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphmapsWithMesh;


namespace ce103_hw7_ahmetburak_yazıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a form 
            //System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
           
            
            /*
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            graph.FindNode("A").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode("C");
            c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;
            
            */
            
            //bind the graph to the viewer 
            gViewer1.Graph = graph;

            gViewer1.Refresh();

            //associate the viewer with the form 
            //form.SuspendLayout();
            //this.SuspendLayout();
            //gViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.Controls.Add(viewer);
            //this.ResumeLayout();
            //show the form 
            //form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;

            graph.AddEdge("C", "D");
            graph.FindNode("D").Attr.FillColor = Microsoft.Msagl.Drawing.Color.Orange;
            graph.FindNode("D").Attr.Shape = Microsoft.Msagl.Drawing.Shape.Hexagon;

            //bind the graph to the viewer 
            gViewer1.Graph = graph;

            gViewer1.Refresh();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;
            graph.AddEdge (textBox3.Text +" "+textBox4.Text, textBox1.Text+" "+textBox2.Text );
            graph.FindNode(textBox3.Text + " " + textBox4.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode(textBox1.Text + " " + textBox2.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

            graph.AddEdge(textBox3.Text + " " + textBox4.Text, textBox5.Text + " " + textBox4.Text);
            graph.AddEdge(textBox1.Text + " " + textBox2.Text, textBox5.Text + " " + textBox4.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            Microsoft.Msagl.Drawing.Node c = graph.FindNode(textBox5.Text + " " + textBox4.Text);
            if (radioButton1.Checked = true)
            { c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Pink; }
            if (radioButton2.Checked = true)
            { c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue; }

            c.Attr.Shape = Microsoft.Msagl.Drawing.Shape.Diamond;


            gViewer1.Graph = graph;


            gViewer1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;

           // if (textBox6.Text.Equals(textBox1.Text) & textBox7.Text.Equals(textBox2.Text))
           
               // if (textBox8.Text.Equals(textBox3.Text) & textBox9.Text.Equals(textBox4.Text))
               
                   // if (graph.Edges.Equals(textBox10.Text + textBox11.Text))
                    
                       Microsoft.Msagl.Drawing.Node deleteNodeName = graph.FindNode(textBox10.Text + textBox11.Text);

            gViewer1.Refresh();
            gViewer1.Graph = graph;
            /*

            if (graph.NodeMap.ContainsKey(deleteNodeName))

            {

                //remove node

                graph.NodeMap.Remove(deleteNodeName);

                //remove all edges referring to the deleted node

                foreach ( Microsoft.Msagl.Core.Layout.Edge edge in graph.Edges.ToArray())

                {

                    if (edge.Source == deleteNodeName || edge.Target == deleteNodeName)

                    {

                        graph.Edges.Remove(edge);

                    }

                }

            }


            gViewer1.Refresh();
            gViewer1.Graph = graph;

            */

        }
        private void gViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;
           
            //female parents
            graph.AddEdge(textBox15.Text + " " + textBox16.Text, textBox13.Text + " " + textBox14.Text);
            graph.FindNode(textBox15.Text + " " + textBox16.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode(textBox13.Text + " " + textBox14.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;

            graph.AddEdge(textBox13.Text + " " + textBox14.Text, textBox12.Text + " " + textBox20.Text);
            graph.AddEdge(textBox15.Text + " " + textBox16.Text, textBox12.Text + " " + textBox20.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //Microsoft.Msagl.Drawing.Node c = graph.FindNode(textBox12.Text + " " + textBox20.Text);

            //male parents
            graph.AddEdge(textBox17.Text + " " + textBox18.Text, textBox19.Text + " " + textBox20.Text);
            graph.FindNode(textBox17.Text + " " + textBox18.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode(textBox19.Text + " " + textBox20.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;

            graph.AddEdge(textBox17.Text + " " + textBox18.Text, textBox21.Text + " " + textBox20.Text);
            graph.AddEdge(textBox19.Text + " " + textBox20.Text, textBox21.Text + " " + textBox20.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //Microsoft.Msagl.Drawing.Node c = graph.FindNode(textBox21.Text + " " + textBox20.Text);

            //marriage edge
            graph.AddEdge(textBox21.Text + " " + textBox20.Text, textBox12.Text + " " + textBox20.Text);

            gViewer1.Refresh();
            gViewer1.Graph = graph;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Microsoft.Msagl.Drawing.Graph graph = gViewer1.Graph;

            //from parents
            graph.AddEdge(textBox35.Text + " " + textBox34.Text, textBox33.Text + " " + textBox32.Text);
            graph.FindNode(textBox35.Text + " " + textBox34.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode(textBox33.Text + " " + textBox32.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;

            graph.AddEdge(textBox35.Text + " " + textBox34.Text, textBox40.Text + " " + textBox32.Text);
            graph.AddEdge(textBox33.Text + " " + textBox32.Text, textBox40.Text + " " + textBox32.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
            //Microsoft.Msagl.Drawing.Node c = graph.FindNode(textBox12.Text + " " + textBox20.Text);

            //to parents
            graph.AddEdge(textBox39.Text + " " + textBox38.Text, textBox37.Text + " " + textBox36.Text);
            graph.FindNode(textBox39.Text + " " + textBox38.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Magenta;
            graph.FindNode(textBox37.Text + " " + textBox36.Text).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;

            /*graph.AddEdge(textBox17.Text + " " + textBox18.Text, textBox21.Text + " " + textBox20.Text);
            graph.AddEdge(textBox19.Text + " " + textBox20.Text, textBox21.Text + " " + textBox20.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;*/


            //adoption edge

            Microsoft.Msagl.Drawing.Node c = graph.FindNode(textBox40.Text + " " + textBox32.Text);

            graph.AddEdge(textBox39.Text + " " + textBox38.Text, textBox40.Text + " " + textBox32.Text);
            graph.AddEdge(textBox37.Text + " " + textBox36.Text, textBox40.Text + " " + textBox32.Text);
            if (radioButton1.Checked = true)
            { c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Pink; }
            if (radioButton2.Checked = true)
            { c.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue; }

            gViewer1.Refresh();
            gViewer1.Graph = graph;
        }
    }
}
