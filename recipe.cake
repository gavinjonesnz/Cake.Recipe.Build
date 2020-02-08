//#load nuget:?package=Cake.Recipe&version=1.1.1
#load setup.selfbootstrap.cake
#load build.recipe.cake

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                            buildSystem: BuildSystem,
                            sourceDirectoryPath: "./src/Cake.Recipe",
                            title: "Cake.Recipe.Build",
                            repositoryOwner: "gavin.jones.nz",
                            repositoryName: "Cake.Recipe.Build");

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context);

RunTarget(BuildParameters.Target);

