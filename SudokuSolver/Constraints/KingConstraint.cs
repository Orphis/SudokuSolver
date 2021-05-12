﻿using System.Collections.Generic;
using System.Text;
using static SudokuSolver.SolverUtility;

namespace SudokuSolver.Constraints
{
    [Constraint(DisplayName = "Anti-King", ConsoleName = "king")]
    public class KingConstraint : ChessConstraint
    {
        public KingConstraint(Solver sudokuSolver, string options) : base(sudokuSolver, "1,1") { }
    }
}
