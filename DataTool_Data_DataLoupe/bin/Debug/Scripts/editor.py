import tkinter as tk
from tkinter import filedialog, messagebox
import toml

def new_file():
    text.delete("1.0", tk.END)
    text.insert(tk.END, toml.dumps({}))

def open_file():
    filepath = filedialog.askopenfilename(filetypes=[("TOML Files", "*.toml")])
    if not filepath:
        return
    try:
        with open(filepath, 'r') as file:
            toml_data = toml.load(file)
            text.delete("1.0", tk.END)
            text.insert(tk.END, toml.dumps(toml_data))
    except toml.TomlDecodeError as e:
        messagebox.showerror("Error", f"Failed to load TOML file:\n{e}")

def save_file(event=None):
    filepath = filedialog.asksaveasfilename(defaultextension=".toml", filetypes=[("TOML Files", "*.toml")])
    if not filepath:
        return
    try:
        toml_data = toml.loads(text.get("1.0", tk.END))
        with open(filepath, 'w') as file:
            toml.dump(toml_data, file)
    except toml.TomlDecodeError as e:
        messagebox.showerror("Error", f"Failed to save TOML file:\n{e}")

root = tk.Tk()
root.title("Parameter Editing Program(Toml)")
root.geometry("400x400")

text = tk.Text(root)
text.pack(expand=True, fill=tk.BOTH)


# Ctrl + O ショートカットキーをバインド
root.bind('<Control-o>',open_file)
# Ctrl + S ショートカットキーをバインド
root.bind('<Control-s>', save_file)

menu = tk.Menu(root)
root.config(menu=menu)

file_menu = tk.Menu(menu)
menu.add_cascade(label="File", menu=file_menu)
file_menu.add_command(label="New", command=new_file)
file_menu.add_command(label="Open (Ctrl + O)", command=open_file)
file_menu.add_command(label="Save As (Ctrl + S)", command=save_file)

root.mainloop()
