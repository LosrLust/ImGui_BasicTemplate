using RenderSpace;

RenderStart renderer = new RenderStart();
Thread renderThread = new Thread(renderer.Start().Wait);
renderThread.Start();