ApplicationConfiguration.Initialize();

int difficult = args.Length == 0 ? 2 : int.Parse(args[0]);
int speed = args.Length <= 1 ? 5000 : int.Parse(args[1]);
int i = -1;
var program = GenerateProgram(difficult);

var timer = new System.Windows.Forms.Timer {
    Interval = 100
};
var label = new Label
{
    Text = "Iniciando...",
    TextAlign = ContentAlignment.MiddleCenter,
    Dock = DockStyle.Fill,
    Font = new Font("arial", 40f),
    ForeColor = Color.White
};

var form = new Form
{
    WindowState = FormWindowState.Maximized,
    FormBorderStyle = FormBorderStyle.None,
    BackColor = Color.Black,
    KeyPreview = true
};

form.Controls.Add(label);

form.KeyDown += (o, e) =>
{
    if (e.KeyCode == Keys.Escape)
        form.Close();
    
    if (e.KeyCode == Keys.Enter)
        i++;
};

form.Load += delegate
{
    timer.Start();
};

int time = 0;
timer.Tick += delegate
{
    if (i == -1)
        return;
    
    time += 100;
    if (time >= speed && i < program.Count - 2)
    {
        time = 0;
        i++;
    }

    if (i < program.Count)
        label.Text = program[i];
};

Application.Run(form);

List<string> GenerateProgram(int difficult)
{
    var nextVar = 'a';
    var nums = 0;
    var lists = 0;
    var vars = new Dictionary<char, object>();
    var list = new List<string>();

    createNum();
    for (int i = 1; i < int.Min(difficult, 10); i++)
    {
        bool ok = false;
        while (!ok)
        {
            var rand = Random.Shared.Next(100);
            
            if (rand < 30 - nums && createNum())
            {
                nums += 10;
                ok = true;
                continue;
            }

            if (rand < 40 - nums - lists && createList() && difficult > 5)
            {
                lists += 10;
                ok = true;
                continue;
            }

            if (rand < 30 && appendNum())
            {
                ok = true;
                continue;
            }

            if (rand < 45 && sumNum() && difficult > 5)
            {
                ok = true;
                continue;
            }

            if (rand < 60 && appendList() && difficult > 7)
            {
                ok = true;
                continue;
            }

            if (rand < 75 && accessList() && difficult > 7)
            {
                ok = true;
                continue;
            }

        }
    }

    var randKey = getRandKey();
    list.Add($"return {randKey}");
    if (vars[randKey] is int num)
        list.Add($"resposta = {num}");
    else if (vars[randKey] is List<object> lst)
        list.Add($"resposta = [ {string.Join(", ", lst)} ]");

    return list;

    bool createNum()
    {
        var value = Random.Shared.Next(10);
        vars[nextVar] = value;
        list.Add($"{nextVar} = {value}");
        nextVar++;
        return true;
    }

    bool appendNum()
    {
        var value = Random.Shared.Next(10);
        var key = getRandKey();
        if (vars[key] is not int num) {
            return false;
        }
        vars[key] = num + value;
        list.Add($"{key} += {value}");
        return true;
    }

    bool sumNum()
    {
        var key1 = getRandKey();
        var key2 = getRandKey();
        if (vars[key1] is not int num1)
            return false;
        if (vars[key2] is not int num2)
            return false;
        vars[key1] = num1 + num2;
        list.Add($"{key1} += {key2}");
        return true;
    }

    bool createList()
    {
        var key1 = getRandKey();
        vars[nextVar] = new List<object> { vars[key1] };
        list.Add($"{nextVar} = [ {key1} ]");
        nextVar++;
        return true;
    }

    bool appendList()
    {
        var listKey = getRandKey();
        var otherKey = getRandKey();
        if (vars[listKey] is not List<object> listvar)
            return false;
        if (vars[otherKey] is not int numvar)
            return false;
        listvar.Add(numvar);
        list.Add($"{listKey}.append({otherKey})");
        return true;
    }

    bool accessList()
    {
        var listKey = getRandKey();
        var otherKey = getRandKey();
        if (vars[listKey] is not List<object> listvar)
            return false;
        if (vars[otherKey] is not int numvar)
            return false;
        var index = Random.Shared.Next(listvar.Count);
        listvar[index] = numvar + (int)listvar[index];
        list.Add($"{listKey}[{index}] += {otherKey}");
        return true;
    }

    char getRandKey()
        => vars.Keys.ToArray()[Random.Shared.Next(vars.Keys.Count)];
}