using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static Lab4.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Form1 : Form
    {

        MyQueue<Student> queue1 = new MyQueue<Student>();
        MyQueue<Student> queue2 = new MyQueue<Student>();
        MyQueue<Student> queue3 = new MyQueue<Student>();

        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

            students.Add(new Student("IC-31", "Петров", ""));
            students.Add(new Student("IC-32", "Іванов", ""));
            students.Add(new Student("IC-33", "Сидорова", ""));
            students.Add(new Student("IC-33", "Шмигельський", ""));
            students.Add(new Student("IC-31", "Коваль", ""));
            students.Add(new Student("IC-32", "Михайлова", ""));

            

            // Відобразимо студентів у ListBox
            DisplayStudents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class Student
        {
            public string Group { get; set; }
            public string Name { get; set; }
            public string Mark { get; set; }

            public Student(string group, string name, string mark)
            {
                Group = group;
                Name = name;
                Mark = "0";
            }

            public override string ToString()
            {
                return $"{Name}, {Group}, Mark: {Mark}";
            }

            
        }

        public class MyQueue<T>
        {
            private class QueueNode
            {
                public T Data;
                public QueueNode Next;

                public QueueNode(T data)
                {
                    Data = data;
                    Next = null;
                }
            }

            private QueueNode _head;
            private QueueNode _tail;

            public MyQueue()
            {
                _head = null;
                _tail = null;
            }

            public void Enqueue(T item)
            {
                QueueNode newNode = new QueueNode(item);
                if (_tail != null)
                {
                    _tail.Next = newNode;
                }
                _tail = newNode;

                if (_head == null)
                {
                    _head = _tail;
                }
            }

            public T Dequeue()
            {
                if (_head == null)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                T dequeuedItem = _head.Data;
                _head = _head.Next;

                if (_head == null)
                {
                    _tail = null;
                }

                return dequeuedItem;
            }

            public bool IsEmpty()
            {
                return _head == null;
            }
        }
        private void DisplayStudents()
        {
            // Очистимо ListBox перед відображенням студентів
            listBox4.Items.Clear();

            // Додамо кожного студента зі списку до ListBox
            foreach (var student in students)
            {
                listBox4.Items.Add(student);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!queue1.IsEmpty())
            {
                outlistBox1.Items.Add(queue1.Dequeue());
                listBox1.Items.RemoveAt(0);

            }
            else if (!queue2.IsEmpty())
            {
                outlistBox2.Items.Add(queue2.Dequeue());
                listBox2.Items.RemoveAt(0);
            }
            else if (!queue3.IsEmpty())
            {
                outlistBox3.Items.Add(queue3.Dequeue());
                listBox3.Items.RemoveAt(0);
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            try
            {
                Student firstStudent = (Student)listBox4.Items[0];

                if (firstStudent.Group == "IC-31")
                {
                    firstStudent.Mark = SetMark.Value.ToString(); 
                    listBox1.Items.Add(firstStudent);
                    queue1.Enqueue(firstStudent);
                }
                else if (firstStudent.Group == "IC-32")
                {
                    firstStudent.Mark = SetMark.Value.ToString();
                    listBox2.Items.Add(firstStudent);
                    queue2.Enqueue(firstStudent);
                }
                else if (firstStudent.Group == "IC-33")
                {
                    firstStudent.Mark = SetMark.Value.ToString(); 
                    listBox3.Items.Add(firstStudent);
                    queue3.Enqueue(firstStudent);
                }

                
                if (listBox4.Items.Count > 0)
                {
                    listBox4.Items.RemoveAt(0);
                }
                else
                {
                    throw new Exception("Неможливо видалити елемент з порожнього listBox4");
                }
            }
            catch 
            {
                MessageBox.Show($"Помилка: listBox порожній", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            outlistBox1.Items.Clear();
            outlistBox2.Items.Clear();
            outlistBox3.Items.Clear();
        }
    }
}
