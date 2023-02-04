using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			//변수선언
			string MyName;
			string MyBirthYear;
			string MyAddress;
			string MyIntroduce;
			int MyAge;
			//질문
			Console.Write("이름 :");
			MyName = Console.ReadLine();
			Console.Write("탄생년도 :");
			MyBirthYear = Console.ReadLine();
			Console.Write("주소 :");
			MyAddress = Console.ReadLine();
			Console.Write("자기소개 :");
			MyIntroduce = Console.ReadLine();

			//띄기
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			//이름
			Console.WriteLine("당신의 이름은 " + MyName + " 입니다.");
			//나이
			MyAge = 2022 - Convert.ToInt32(MyBirthYear);
			Console.WriteLine("당신의 만 나이는 " + MyAge + "살 입니다.");
			//주소
			Console.WriteLine("당신의 주소는 " + MyAddress + " 입니다.");
			//자기소개
			Console.WriteLine("당신이 한 자기소개 : " + MyIntroduce);
		}
	}
}
