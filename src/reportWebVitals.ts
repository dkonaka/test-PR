/**
 * reportWebVitals.ts
 * 
 * This file provides functionality to measure and report web performance metrics.
 * It uses the web-vitals library to collect Core Web Vitals and other performance metrics.
 */
import { ReportHandler } from 'web-vitals';

/**
 * Reports web vitals metrics using the provided callback function
 * 
 * @param onPerfEntry - Optional callback function to handle performance entries
 * 
 * The function measures the following metrics:
 * - CLS (Cumulative Layout Shift): Visual stability metric
 * - FID (First Input Delay): Interactivity metric
 * - FCP (First Contentful Paint): Loading metric
 * - LCP (Largest Contentful Paint): Loading metric
 * - TTFB (Time to First Byte): Server response time metric
 */
const reportWebVitals = (onPerfEntry?: ReportHandler): void => {
  // Only proceed if a valid callback function is provided
  if (onPerfEntry && onPerfEntry instanceof Function) {
    // Dynamically import the web-vitals library to reduce initial bundle size
    import('web-vitals').then(({ getCLS, getFID, getFCP, getLCP, getTTFB }) => {
      // Measure and report each performance metric
      getCLS(onPerfEntry); // Cumulative Layout Shift
      getFID(onPerfEntry); // First Input Delay
      getFCP(onPerfEntry); // First Contentful Paint
      getLCP(onPerfEntry); // Largest Contentful Paint
      getTTFB(onPerfEntry); // Time To First Byte
    });
  }
};

export default reportWebVitals;
