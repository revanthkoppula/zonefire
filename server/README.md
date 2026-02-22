FireRunner Python server prototype
=================================

Run (local):

1. Create a virtualenv and install deps:

```powershell
python -m venv .venv
.\.venv\Scripts\Activate.ps1
python -m pip install -r requirements.txt
```

2. Start the app with uvicorn:

```powershell
uvicorn server.app:app --reload --host 127.0.0.1 --port 8000
```

3. Quick checks:

```
curl http://127.0.0.1:8000/health
curl "http://127.0.0.1:8000/hello?name=Alice"
```
