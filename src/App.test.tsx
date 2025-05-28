/**
 * App.test.tsx
 * 
 * This file contains tests for the App component.
 * It uses React Testing Library to render and test the component.
 */
import React from 'react';
import { render, screen } from '@testing-library/react';
import App from './App';

/**
 * Test case to verify that the App component renders the "Learn React" link
 * 
 * This test:
 * 1. Renders the App component
 * 2. Searches for text matching "learn react" (case-insensitive)
 * 3. Verifies that the element is present in the document
 */
test('renders learn react link', () => {
  // Render the App component into the virtual DOM
  render(<App />);
  
  // Find the link element by its text content (case-insensitive regex)
  const linkElement = screen.getByText(/learn react/i);
  
  // Assert that the link element is present in the document
  expect(linkElement).toBeInTheDocument();
});
