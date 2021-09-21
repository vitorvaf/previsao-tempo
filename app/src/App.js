import "./styles/App.css"
import History from "./components/History";
import Card from "./components/Card";

function App() {
  return (
    <div className="App">
      <header>
        <meta charSet="UTF-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <title>Previsão do tempo</title>
      </header>
      <div className="card">
        <Card />             
      </div>
    </div>
  );
}

export default App;
