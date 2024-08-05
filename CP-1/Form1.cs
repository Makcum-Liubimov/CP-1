using CP_1;
using static CP_1.Program;

namespace CP_1
{
    public partial class Form1 : Form
    {
        private Schedule_Nod[] schedule;
        private List<Schedule_Nod> userTickets;

        public Form1()
        {
            InitializeComponent();
            userTickets = new List<Schedule_Nod>();
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            schedule = new Schedule_Nod[]
            {
                new Schedule_Nod { IsTrainToday = true, TrainNumber = 1, Destination = "Kyiv" },
                new Schedule_Nod { IsTrainToday = false, TrainNumber = 2, Destination = "Lviv" },
                new Schedule_Nod { IsTrainToday = true, TrainNumber = 3, Destination = "Odessa" }
            };
        }

        private void showScheduleButton_Click(object sender, EventArgs e)
        {
            scheduleListBox.Items.Clear();
            for (int i = 0; i < schedule.Length; i++)
            {
                var node = schedule[i];
                scheduleListBox.Items.Add($"������� {i + 1}: ����� �{node.TrainNumber}, ����� �����������: {node.Destination}, ��������� �������: {node.IsTrainToday}");
            }
        }

        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            if (scheduleListBox.SelectedItem != null)
            {
                int selectedIndex = scheduleListBox.SelectedIndex;
                if (schedule[selectedIndex].IsTrainToday)
                {
                    userTickets.Add(schedule[selectedIndex]);
                    MessageBox.Show("������ ��������!");
                    myTicketsButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("����� ������� �����������.");
                }
            }
            else
            {
                MessageBox.Show("���� �����, ������ ����� � ��������.");
            }
        }

        private void myTicketsButton_Click(object sender, EventArgs e)
        {
            ticketsListBox.Items.Clear();
            foreach (var ticket in userTickets)
            {
                ticketsListBox.Items.Add($"����� �{ticket.TrainNumber}, ����� �����������: {ticket.Destination}");
            }
        }
    }

    public class Schedule_Nod
    {
        public bool IsTrainToday { get; set; }
        public int TrainNumber { get; set; }
        public string Destination { get; set; }

        public Schedule_Nod(bool isTrainToday, int trainNumber, string destination)
        {
            IsTrainToday = isTrainToday;
            TrainNumber = trainNumber;
            Destination = destination;
        }
        public Schedule_Nod()
        {
            IsTrainToday = false;
            TrainNumber = -1;
            Destination = "final";
        }
    }
    // ���� ��� ��������� ������ �����������
    public class UserTickets
    {
        private List<(string day, string trainNumber)> tickets = new List<(string day, string trainNumber)>();

        public void AddTicket(string day, string trainNumber)
        {
            tickets.Add((day, trainNumber));
        }

        public string GetTicketsInfo()
        {
            if (tickets.Count == 0)
            {
                return "� ��� ���� ��������� ������.";
            }

            string info = "���� ������:\n";
            foreach (var ticket in tickets)
            {
                info += $"����: {ticket.day}, ����� ������: {ticket.trainNumber}\n";
            }
            return info;
        }
    }
}