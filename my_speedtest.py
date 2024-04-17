import speedtest
import tkinter as tk

root = tk.Tk()
root.title("Speedtest")
root.configure(bg='#000080', height=500, width=500) # Change the background color

def run_speedtest():
    charging_label.config(text="Running speedtest...")
    root.update()
    s = speedtest.Speedtest()
    download_speed = s.download() / 1024 / 1024
    upload_speed = s.upload() / 1024 / 1024
    result_label.config(text=f"Download: {download_speed:.2f} Mb/s\nUpload: {upload_speed:.2f} Mb/s")
    charging_label.config(text="Speedtest complete.")

start_button = tk.Button(root, text="Run Speedtest", command=run_speedtest, bg='#00FFFF', fg='#000000', font=("Arial", 20), borderwidth=5, padx=20, pady=10)
start_button.pack(pady=20)

charging_label = tk.Label(root, text="Click on the button to make the speedtest start", bg='#000080', fg='#FFFFFF', font=("Arial", 20))
charging_label.pack()

result_label = tk.Label(root, text="", bg='#000080', fg='#FFFFFF', font=("Arial", 20))
result_label.pack()

root.mainloop()