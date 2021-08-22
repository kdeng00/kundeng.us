# kundeng.us

### TODO
Casually start making your own website. No rush and no deadlines


## Experiment

Try out React. Don't bother updating your python dependencies.



## Required
* Python >= 3.6.9
* Django >= 3.0.7
* Pip3 >= 20.1
* Virtualenv >= 15.1.0


## Running
1. Clone repo
```Bash 
git clone https://github.com/kdeng00/kundeng.us
```
2. Change directories to the cloned repository
3. Create virtual environment and then activate the environment
```Bash
virtualenv env && source env/bin/activate
```
4. With pip install Django
```
Bash pip3 install -r requirements.txt
```
5. Run server on 127.0.0.1 port 8000
```Bash
python manage.py runserver
```
To hit the web app via your ip, run like so:
```Bash
python manage.py 0.0.0.0:[8000]
```
Then open a browser and go to ``http://[your_ip_address]:8000``
