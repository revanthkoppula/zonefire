from fastapi import FastAPI

app = FastAPI(title="FireRunner Prototype API")


@app.get("/health")
async def health() -> dict:
    """Health check for the server."""
    return {"status": "ok"}


@app.get("/hello")
async def hello(name: str = "world") -> dict:
    """Simple hello endpoint for quick verification.

    Use: GET /hello?name=Alice
    """
    return {"message": f"hello {name}"}
