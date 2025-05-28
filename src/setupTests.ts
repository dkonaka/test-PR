/**
 * setupTests.ts
 * 
 * This file configures the testing environment for the React application.
 * It's automatically included before each test file runs.
 */

// jest-dom adds custom jest matchers for asserting on DOM nodes.
// allows you to do things like:
// expect(element).toHaveTextContent(/react/i)
// learn more: https://github.com/testing-library/jest-dom

/**
 * Import jest-dom to extend Jest with custom DOM element matchers
 * 
 * This provides additional assertion methods like:
 * - toBeInTheDocument()
 * - toHaveTextContent()
 * - toBeVisible()
 * - toBeDisabled()
 * - toHaveClass()
 * 
 * These matchers make tests more readable and expressive when testing UI components.
 */
import '@testing-library/jest-dom';
