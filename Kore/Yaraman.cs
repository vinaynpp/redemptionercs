// using YaraSharp;


// //  All API calls happens here
// YSInstance YSInstance = new YSInstance();
        
// //  Declare external variables (could be null)
// Dictionary<string, object> externals = new Dictionary<string, object>()
// {
//     { "filename", string.Empty },
//     { "filepath", string.Empty },
//     { "extension", string.Empty }
// };

// //	Get list of YARA rules
// List<string> ruleFilenames = Directory.GetFiles(@"D:\Test\yara", "*.yar", SearchOption.AllDirectories).ToList();

// //  Context is where yara is initialized
// //  From yr_initialize() to yr_finalize()
// using (YSContext context = new YSContext())
// {
//     //	Compiling rules
//     using (YSCompiler compiler = instance.CompileFromFiles(ruleFilenames, externals))
//     {
//         //  Get compiled rules
//         YSRules rules = compiler.GetRules();

//         //  Get errors
//         YSReport errors = compiler.GetErrors();
//         //  Get warnings
//         YSReport warnings = compiler.GetWarnings();


//         //  Some file to test yara rules
//         string Filename = @"";

// 		//  Get matches
// 		List<YSMatches> Matches = instance.ScanFile(Filename, rules,
// 				new Dictionary<string, object>()
// 				{
// 					{ "filename", Alphaleonis.Win32.Filesystem.Path.GetFileName(Filename) },
// 					{ "filepath", Alphaleonis.Win32.Filesystem.Path.GetFullPath(Filename) },
// 					{ "extension", Alphaleonis.Win32.Filesystem.Path.GetExtension(Filename) }
// 				}, 
// 				0);

// 		//  Iterate over matches
// 		foreach (YSMatches Match in Matches)
// 		{
// 			//...
// 		}
// 	}
// 	//  Log errors
// }