/**
 * App.tsx
 * 
 * This is the main React component for the application.
 * It renders the application header with the React logo and a link to the React documentation.
 */
import React from 'react';
import logo from './logo.svg'; // Import the React logo SVG
import './App.css'; // Import component-specific styles

/**
 * App component - The root component of the React application
 * 
 * @returns {JSX.Element} The rendered App component
 */
function App(): JSX.Element {
  return (
    <div className="App">
      {/* Application header section */}
      <header className="App-header">
        {/* React logo */}
        <img src={logo} className="App-logo" alt="logo" />
        
        {/* Instructions for development */}
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        
        {/* Link to React documentation */}
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

// Export the App component as the default export
export default App;
