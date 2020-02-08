
Task("Generate-Version-File-Cake")
    .Does(() => {
        var buildMetaDataCodeGen = TransformText(@"
        public class BuildMetaData
        {
            public static string Date { get; } = ""<%date%>"";
            public static string Version { get; } = ""<%version%>"";
        }",
        "<%",
        "%>"
        )
   .WithToken("date", DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"))
   .WithToken("version", BuildParameters.Version.SemVersion)
   .ToString();

        System.IO.File.WriteAllText(
        "./Cake.Recipe/Cake.Recipe/Content/version.cake",
        buildMetaDataCodeGen
        );
    });
