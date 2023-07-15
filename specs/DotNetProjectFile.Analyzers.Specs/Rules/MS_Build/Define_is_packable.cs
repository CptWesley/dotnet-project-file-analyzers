﻿namespace Rules.MS_Build.Define_is_packable;

public class Reports
{
    [Test]
    public void on_no_is_packable()
       => new DefineIsPackable()
       .ForProject("NoIsPackable.cs")
       .HasIssue(
           new Issue("Proj0012", "Define the <IsPackable> node explicitly."));
}

public class Guards
{
    [TestCase("CompliantCSharp.cs")]
    [TestCase("CompliantVB.vb")]
    public void Projects_without_issues(string project)
         => new DefineIsPackable()
        .ForProject(project)
        .HasNoIssues();
}