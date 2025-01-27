﻿namespace Rules.RESX.Add_invariant_fallback_values;

public class Reports
{
    [Test]
    public void missing_invariant_resource()
        => new Resx.AddInvariantFallbackValues()
        .ForProject("ResxMissingInvariant.cs")
        .HasIssues(
            new Issue("Proj2004", "Add invariant fallback value for 'Bishop'.").WithSpan(11, 3, 13, 9),
            new Issue("Proj2004", "Add invariant fallback value for 'Rook'.").WithSpan(0014, 3, 16, 9),
            new Issue("Proj2004", "Add invariant fallback value for 'Knight'.").WithSpan(11, 3, 13, 9),
            new Issue("Proj2004", "Add invariant fallback value for 'Pawn'.").WithSpan(0014, 3, 16, 9));
}

public class Guards
{
    [TestCase("CompliantCSharp.cs")]
    [TestCase("CompliantVB.vb")]
    public void sorted_data(string project)
         => new Resx.AddInvariantFallbackValues()
        .ForProject(project)
        .HasNoIssues();
}

public class Ignores
{
    [Test]
    public void invalid_resources()
         => new Resx.AddInvariantFallbackValues()
        .ForProject("ResxNoXml.cs")
        .HasNoIssues();

    [Test]
    public void missing_invariant_resource()
        => new Resx.AddInvariantFallbackValues()
       .ForProject("ResxNoInvariant.cs")
       .HasNoIssues();
}
