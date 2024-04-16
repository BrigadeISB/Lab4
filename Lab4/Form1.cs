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
using System.Diagnostics;
using static Lab4.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        MyQueue<Student> queue1 = new MyQueue<Student>();
        MyQueue<Student> queue2 = new MyQueue<Student>();
        MyQueue<Student> queue3 = new MyQueue<Student>();

        ArrayQueue<Student> Arrqueue1 = new ArrayQueue<Student>(5);
        ArrayQueue<Student> Arrqueue2 = new ArrayQueue<Student>(5);
        ArrayQueue<Student> Arrqueue3 = new ArrayQueue<Student>(5);

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
            students.Add(new Student("IC-32", "Мельник", ""));
            students.Add(new Student("IC-33", "Шевченко", ""));
            students.Add(new Student("IC-31", "Мороз", ""));



            
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

        public class ArrayQueue<T>
        {
            private T[] _items;
            private int _head; 
            private int _tail;
            private int _size; 

            public ArrayQueue(int capacity)
            {
                _items = new T[capacity];
                _head = 0;
                _tail = -1;
                _size = 0;
            }

            public void Enqueue(T item)
            {
                if (_size == _items.Length)
                {
                    
                    Array.Resize(ref _items, _items.Length * 2);
                }

                _tail = (_tail + 1) % _items.Length; 
                _items[_tail] = item;
                _size++;
            }

            public T Dequeue()
            {
                if (_size == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                T dequeued = _items[_head];
                _items[_head] = default(T); 
                _head = (_head + 1) % _items.Length; 
                _size--;

                return dequeued;
            }

            public T Peek()
            {
                if (_size == 0)
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                return _items[_head];
            }

            public int Count
            {
                get { return _size; }
            }

            public bool IsEmpty()
            {
                return _size == 0; 
            }
        }
        private void DisplayStudents()
        {
            
            listBox4.Items.Clear();

            
            foreach (var student in students)
            {
                listBox4.Items.Add(student);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (!queue1.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = queue1.Dequeue();
                    stopwatch.Stop();
                    outlistBox1.Items.Add(el);
                    listBox1.Items.RemoveAt(1);
                    listBox1.Items.RemoveAt(0);
                    outlistBox1.Items.Add($"Execution time: {stopwatch.Elapsed}");

                }
                else if (!queue2.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = queue2.Dequeue();
                    stopwatch.Stop();
                    outlistBox2.Items.Add(el);
                    listBox2.Items.RemoveAt(1);
                    listBox2.Items.RemoveAt(0);
                    outlistBox2.Items.Add($"Execution time: {stopwatch.Elapsed}");
                }
                else if (!queue3.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = queue3.Dequeue();
                    stopwatch.Stop();
                    outlistBox3.Items.Add(el);
                    listBox3.Items.RemoveAt(1);
                    listBox3.Items.RemoveAt(0);
                    outlistBox3.Items.Add($"Execution time: {stopwatch.Elapsed}");
                }
            }
            if (radioButton2.Checked)
            {
                if (!Arrqueue1.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = Arrqueue1.Dequeue();
                    stopwatch.Stop();
                    outlistBox1.Items.Add(el);                   
                    listBox1.Items.RemoveAt(1);
                    listBox1.Items.RemoveAt(0);
                    outlistBox1.Items.Add($"Execution time: {stopwatch.Elapsed}");

                }
                else if (!Arrqueue2.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = Arrqueue2.Dequeue();
                    stopwatch.Stop();
                    outlistBox2.Items.Add(el);
                    listBox2.Items.RemoveAt(1);
                    listBox2.Items.RemoveAt(0);
                    outlistBox2.Items.Add($"Execution time: {stopwatch.Elapsed}");
                }
                else if (!Arrqueue3.IsEmpty())
                {
                    stopwatch.Restart();
                    var el = Arrqueue3.Dequeue();
                    stopwatch.Stop();
                    outlistBox3.Items.Add(el);
                    listBox3.Items.RemoveAt(1);
                    listBox3.Items.RemoveAt(0);
                    outlistBox3.Items.Add($"Execution time: {stopwatch.Elapsed}");
                }
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

            if (radioButton1.Checked)
            {
                try
                {
                    Student firstStudent = (Student)listBox4.Items[0];

                    if (firstStudent.Group == "IC-31")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox1.Items.Add(firstStudent);
                        stopwatch.Restart();
                        queue1.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox1.Items.Add($"Execution time: {stopwatch.Elapsed}");
                    }
                    else if (firstStudent.Group == "IC-32")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox2.Items.Add(firstStudent);
                        stopwatch.Restart();
                        queue2.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox2.Items.Add($"Execution time: {stopwatch.Elapsed}");
                    }
                    else if (firstStudent.Group == "IC-33")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox3.Items.Add(firstStudent);
                        stopwatch.Restart();
                        queue3.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox3.Items.Add($"Execution time: {stopwatch.Elapsed}");
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

            if (radioButton2.Checked)
            {
                try
                {
                    Student firstStudent = (Student)listBox4.Items[0];

                    if (firstStudent.Group == "IC-31")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox1.Items.Add(firstStudent);
                        stopwatch.Restart();
                        Arrqueue1.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox1.Items.Add($"Execution time: {stopwatch.Elapsed}");
                    }
                    else if (firstStudent.Group == "IC-32")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox2.Items.Add(firstStudent);
                        stopwatch.Restart();
                        Arrqueue2.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox2.Items.Add($"Execution time: {stopwatch.Elapsed}");
                    }
                    else if (firstStudent.Group == "IC-33")
                    {
                        firstStudent.Mark = SetMark.Value.ToString();
                        listBox3.Items.Add(firstStudent);
                        stopwatch.Restart();
                        Arrqueue3.Enqueue(firstStudent);
                        stopwatch.Stop();
                        listBox3.Items.Add($"Execution time: {stopwatch.Elapsed}");
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            outlistBox1.Items.Clear();
            outlistBox2.Items.Clear();
            outlistBox3.Items.Clear();
        }
    }
}
