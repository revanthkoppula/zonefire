import pytest

from httpx import AsyncClient


@pytest.mark.asyncio
async def test_health_and_hello():
    from server.app import app

    async with AsyncClient(app=app, base_url="http://test") as ac:
        r = await ac.get("/health")
        assert r.status_code == 200
        assert r.json() == {"status": "ok"}

        r2 = await ac.get("/hello", params={"name": "Tester"})
        assert r2.status_code == 200
        assert r2.json() == {"message": "hello Tester"}
