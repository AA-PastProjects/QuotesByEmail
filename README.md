# QuotesByEmail

Project from the spring of 2018 - during my 1st semester of my PBA in software development.

A console application made in .NET Core and C#.

This application does the following upon startup.

1. Receives your email and name.
2. Checks if the email appears even slightly valid (e.g. has an @ symbol in it).
3. Contacts an external API which in JSON replies with a quote and the author of the quote.
4. Separate the author out from the JSON reply.
5. Contacts wikipedias API with the authors name and gets a JSON reply.
6. Fetches the first section of the wikipedia page JSON.
7. Creates an email with both the quote, author and wikipedia information.
8. Sends the email to the given email address via an SMTP protocol that goes to the external mail service Mailgun.

If everything went as intended (and your email + mailgun settings were set up correctly) you will shortly after get an email with the content acquired by the service.