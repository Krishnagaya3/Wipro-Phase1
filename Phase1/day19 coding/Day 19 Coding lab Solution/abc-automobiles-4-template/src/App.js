import logo from './logo.svg';
import './App.css';
import Nav from './nav';
import Footer from './footer';

function App() {
  return (
    <div className="App">
      <div className='container'>
        <Nav></Nav>
        <h2 data-testid="home-content">Welcome to ABC Automobiles</h2>
        <Footer></Footer>
      </div>
    </div>
  );
}

export default App;
