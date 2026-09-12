using Core;
static void Check(bool ok,string message){if(!ok)throw new Exception(message);}
var generator=new TemplateRequirementsGenerator();
var plan=generator.Generate(new("Export CSV","Export filtered records to CSV","an organizer","Free only"));
Check(plan.Markdown.Contains("formula injection"),"CSV safety requirement");
Check(plan.Markdown.Contains("Acceptance criteria") && plan.Markdown.Contains("Free only"),"Structure and constraints");
Check(generator.Generate(new("Login","Add authentication","a user","")).Markdown.Contains("server"),"Server authorization");
Check(generator.Generate(new("Reminders","Send notifications","a user","")).Markdown.Contains("timezone"),"Notification timezone");
var url=GitHubDraft.Url("owner/repo",new("a & b","hello # world"));Check(url.Host=="github.com" && url.Query.Contains("%26"),"Safe URL encoding");
try{GitHubDraft.Url("https://evil.example",plan);throw new Exception("Invalid destination accepted");}catch(ArgumentException){}
try{generator.Generate(new("","", "", ""));throw new Exception("Empty input accepted");}catch(ArgumentException){}
Console.WriteLine("PASS: CSV, structured content, authorization, reminders, URL encoding and validation (7 checks)");
