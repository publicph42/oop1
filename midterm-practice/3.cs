using system;

class server
{
    public server()
    {
        console.writeline("server default");       // [a]
    }

    public server(string ip)
    {
        console.writeline("server ip configured"); // [4]
    }
}

class webserver : server
{
    private string domain;                         // [3]

    // constructor 1
    public webserver() : this("localhost")
    {
        console.writeline("webserver default");    // [6]
    }

    // constructor 2
    public webserver(string domain) : base("127.0.0.1")
    {
        // 'this' distinguishes the class field from the local parameter
        this.domain = domain; 
        console.writeline("webserver domain");     // [5]
    }
}

class program
{
    static void main()
    {
        console.writeline("app start");               // [1]
        webserver pluto = new webserver();            // [2]
    }
}