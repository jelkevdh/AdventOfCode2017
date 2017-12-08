using System;

namespace AdventOfCode2017 {
  class Program {
    static void Main(string[] args) {
      var problem = new Day2.Problem2();

      string input = problem.ReadInput();

      try {
        problem.Solve(input);
      }
      catch (Exception e) {
        Console.WriteLine("Error solving the problem: " + e.Message);
      }

      ShowPressEnterToExit();
    }

    /// <summary>
    /// Shows the press-enter-to-exit message and waits for the user to press enter.
    /// </summary>
    static void ShowPressEnterToExit() {
      Console.WriteLine(String.Empty);
      Console.WriteLine("Press [enter] to exit");
      Console.ReadLine();
    }
  }
}
