using System;

namespace AdventOfCode2017 {
  public abstract class Problem {
    /// <summary>
    /// The name of this problem.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The default input.
    /// </summary>
    public string DefaultInput { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Problem"/> class.
    /// </summary>
    /// <param name="name">The name of this problem.</param>
    /// <param name="defaultInput">The default input.</param>
    protected Problem(string name, string defaultInput) {
      Name = name;
      DefaultInput = defaultInput;
    }

    /// <summary>
    /// Reads the puzzle input.
    /// </summary>
    /// <returns>The puzzle input.</returns>
    public virtual string ReadInput() {
      string input;

      do {
        Console.WriteLine($"-=[ {Name} ]=-");
        string defaultText = String.IsNullOrEmpty(DefaultInput) ? String.Empty : $" [{DefaultInput}]";
        Console.WriteLine($"Enter sequence{defaultText}:");
        input = Console.ReadLine();

        if (input == "") {
          input = DefaultInput;
        }

      } while (!IsInputValid(input));

      return input;
    }

    /// <summary>
    /// Returns a value indicating whether the specified input is valid.
    /// </summary>
    /// <param name="input">The input to check.</param>
    /// <returns><c>true</c> if valid and <c>false</c> otherwise.</returns>
    public virtual bool IsInputValid(string input) {
      return !String.IsNullOrWhiteSpace(input);
    }
  }
}
