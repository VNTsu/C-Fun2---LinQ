using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Học1
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Member> NewMember = new List<Member>();
            ///// Them ban ghi
            DateTime DateMember1 = new DateTime(2003, 03, 26);
            Member member1 = new Member("Tien", "Pham", TypeGender.Male , DateMember1, "0963164813", "HaNoi", DateTime.Now.Year - DateMember1.Year, true);
            NewMember.Add(member1);
            DateTime DateMember2 = new DateTime(1981, 03, 26);
            Member member2 = new Member("Hoang", "Pham", TypeGender.Male, DateMember2, "0963164813", "BacNinh", DateTime.Now.Year - DateMember2.Year, true);
            NewMember.Add(member2);
            DateTime DateMember3 = new DateTime(1992, 03, 26);
            Member member3 = new Member("Quang", "Pham", TypeGender.Male, DateMember3, "0963164813", "HaNoi", DateTime.Now.Year - DateMember3.Year, false);
            NewMember.Add(member3);
            DateTime DateMember4 = new DateTime(1999, 03, 26);
            Member member4 = new Member("Thu", "Nguyen", TypeGender.Female, DateMember4, "90235790", "BacNinh", DateTime.Now.Year - DateMember4.Year, true);
            NewMember.Add(member4);
            DateTime DateMember5 = new DateTime(2000, 03, 26);
            Member member5 = new Member("Tien", "Hoang", TypeGender.Male, DateMember5, "0963164123", "BacNinh", DateTime.Now.Year - DateMember5.Year, true);
            NewMember.Add(member5);
            //Tạo Menu
            int chon;
            Process rp = new Process();
            Home:
                Console.WriteLine("***************MAIN MENU**********");
                Console.WriteLine("*******=======================********");
                Console.WriteLine("1.   Hiển thị người giới tính nam");
                Console.WriteLine("2.   Hiển thị người già nhất");
                Console.WriteLine("3.   Hiển thị tên đầy đủ ");
                Console.WriteLine("4.   Hiển thị 3 List");
                Console.WriteLine("5.   Hiển thị người đầu tiên sinh ở HN");
            Console.Write("===> Nhập vào lựa chọn:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("//============================================================");
                        Console.WriteLine("1. Hien thi nhung nguoi gioi tinh nam:");
                        List<Member> listMale = rp.ListMale(NewMember);
                        foreach (var item in listMale)
                    {
                        Console.WriteLine("Tên: {0}, Giới tính: {1}, Ngày sinh: {2}, SĐT:{3}, Nơi sinh: {4}, Age: {5}, Tốt nghiệp: {6}", item.FirtName + " " + item.LastName, item.Gender.ToString(), item.DateOfBirth, item.PhoneNumber, item.BirthPlace, item.Age, item.Graduated ? "Yes" : "No");
                    }
                    break;
                    case 2:
                        Console.WriteLine("//============================================================");
                            Console.WriteLine("2. Hien thi nguoi co tuoi lon nhat:");
                    Member Oldest = rp.Oldest(NewMember);              
                        Console.WriteLine("Tên là:{0}, Ngày sinh: {1}, Nơi sinh: {2}, Tuổi:{3}",Oldest.FirtName +" "+ Oldest.LastName,Oldest.DateOfBirth,Oldest.BirthPlace,Oldest.Age);
                        break;                  
                    case 3:
                       Console.WriteLine("//============================================================");
                       Console.WriteLine("3. Hiển thị tên đầy đủ: ");
                    List<Member> FullMember = rp.FullMember(NewMember);
                    foreach (var item in FullMember) Console.WriteLine(item.FirtName + " " + item.LastName);
                    break;
                    case 4:
                    List<Member> list2k = rp.List2k(NewMember);
                    List<Member> listmore2k = rp.ListMore2K(NewMember);
                    List<Member> listunder2k = rp.Listunder2k(NewMember);
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("Danh sách sinh năm 2000:");
                    foreach (var mem in list2k)
                    {                      
                        Console.WriteLine("Tên: {0}, Sinh năm: {1}",mem.FirtName +" "+mem.LastName,mem.DateOfBirth);
                    }
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("Danh sách sinh năm trên 2000:");
                    foreach (var mem in listmore2k)
                    {
                        Console.WriteLine("Tên: {0}, Sinh năm: {1}", mem.FirtName + " " + mem.LastName, mem.DateOfBirth);
                    }
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("Danh sách sinh năm dưới 2000:");
                    foreach (var mem in listunder2k)
                    {
                        Console.WriteLine("Tên: {0}, Sinh năm: {1}", mem.FirtName + " " + mem.LastName, mem.DateOfBirth);
                    }
                    break;
                    case 5:
                        Member InHN = rp.ListHn(NewMember);
                        Console.WriteLine("Kết quả ===============================================================");
                        Console.WriteLine("Tên người đầu tiên sống ở HN là:{0}, Tuổi: {1}, Nơi sinh: {2}, Ngày sinh: {3}, Giới tính: {4}", InHN.FirtName +" "+ InHN.LastName, InHN.Age, InHN.BirthPlace, InHN.DateOfBirth, InHN.Gender.ToString());                                    
                    break;               
                    default: 
                        Console.WriteLine("Mời chọn lại");
                        goto Home;                
                        Console.ReadLine();
                }
            Console.ReadKey();
        }
    }

} 

