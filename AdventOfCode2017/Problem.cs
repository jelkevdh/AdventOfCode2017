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
    /// Value indicating whether the input is multiline.
    /// </summary>
    protected bool MultiLineInput { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Problem"/> class.
    /// </summary>
    /// <param name="name">The name of this problem.</param>
    /// <param name="defaultInput">The default input.</param>
    protected Problem(string name, bool multiLineInput, string defaultInput) {
      Name = name;
      DefaultInput = defaultInput;
      MultiLineInput = multiLineInput;
    }

    /// <summary>
    /// Reads the puzzle input.
    /// </summary>
    /// <returns>The puzzle input.</returns>
    public virtual string ReadInput() {
      Console.WriteLine($"-=[ {Name} ]=-");
      string defaultText = String.IsNullOrEmpty(DefaultInput) ? String.Empty : $" [{DefaultInput}]";
      Console.WriteLine($"Enter sequence{defaultText}:");

      return MultiLineInput ? ReadMultiLineInput() : ReadSingleLineInput();
    }

    /// <summary>
    /// Reads the single-line puzzle input.
    /// </summary>
    /// <returns>The puzzle input.</returns>
    protected virtual string ReadSingleLineInput() {
      string input;

      do {
        input = Console.ReadLine();

        if (input == "") {
          input = DefaultInput;
        }

      } while (!IsInputValid(input));

      return input;
    }

    /// <summary>
    /// Reads the multi-line puzzle input.
    /// </summary>
    /// <returns>The puzzle input.</returns>
    protected virtual string ReadMultiLineInput() {
      string input = "";
      string line;
      bool first = true;

      do {
        line = Console.ReadLine();

        if (first && line == "") {
          input = DefaultInput;
        } else {
          first = false;
        }

        if (line != String.Empty) {
          input += line + Environment.NewLine;
        }
      } while (line != String.Empty);

      return input.Trim();
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
