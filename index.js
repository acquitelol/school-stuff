import { exec } from 'child_process';

class Shell {
    static async write(text) {
        return await new Promise((resolve) => {
            process.stdout.write(text);
            resolve(text);
        });
    }
    static async run(command = 'ls', after = (stderr, stdout) => { }) {
        return await new Promise((resolve) => {
            exec(command, (stderr, stdout) => {
                after(stderr, stdout);
                resolve(stdout);
            });
        });
    }
}

class Colors {
    constructor() {
        this.RED = '\x1b[91m';
        this.GREEN = '\x1b[92m';
        this.BLUE = '\x1b[94m';
        this.PINK = '\x1b[95m';
        this.CYAN = '\x1b[96m';
        this.ENDC = '\x1b[0m';
    }
}

const Main = async () => {
    const c = new Colors();
    const START_TIME = Date.now();
    await Shell.run("dotnet publish & wait $!", async (stderr, stdout) => {
        stdout && await Shell.write(stdout);
        // stderr && await Shell.write(stderr.message);
    });
    const END_TIME = Date.now();

    await Shell.write(`${c.PINK}<${c.CYAN}${process.argv[2]}.cs${c.PINK}> ${c.GREEN}Built Sucessfully in ${c.PINK}${(END_TIME-START_TIME)/1000} ${c.CYAN}seconds.${c.ENDC}`);
    await Shell.run(`dotnet ./bin/Debug/net6.0/publish/${process.argv[3]}.dll`, async (stderr, stdout) => {
        await Shell.write("\n" + stdout + '\n');
    });
}

Main();