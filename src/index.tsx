/**
 * index.tsx
 * 
 * This is the entry point for the React application.
 * It renders the root App component into the DOM and sets up web vitals reporting.
 */
import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css'; // Import global styles
import App from './App'; // Import the main App component
import reportWebVitals from './reportWebVitals'; // Import performance measurement utility

/**
 * Create a React root using the 'root' element from the HTML
 * The type assertion (as HTMLElement) ensures TypeScript knows this element exists
 */
const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);

/**
 * Render the App component inside React's StrictMode
 * 
 * StrictMode enables additional development checks and warnings
 * It helps identify potential problems in the application
 */
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
