import { fireEvent, getByTestId, render, screen, waitFor, } from '@testing-library/react';
import App from './App';
import AddVehicle from './add-vehicle';
import axios from 'axios'; // Import Axios for mocking


test('check form fields', () => {
  render(<AddVehicle />);
  const image = screen.getByTestId("image");
  const name = screen.getByTestId("name");
  const price = screen.getByTestId("price");
  const mileage = screen.getByTestId("mileage");
  const color = screen.getByTestId("color");
  const seats = screen.getByTestId("seats");
  const fuel = screen.getByTestId("fuel");
  const gear = screen.getByTestId("gear");
  const description = screen.getByTestId("description");

  expect(image).toBeInTheDocument();
  expect(name).toBeInTheDocument();
  expect(price).toBeInTheDocument();
  expect(mileage).toBeInTheDocument();
  expect(color).toBeInTheDocument();
  expect(seats).toBeInTheDocument();
  expect(fuel).toBeInTheDocument();
  expect(gear).toBeInTheDocument();
  expect(description).toBeInTheDocument();
});

jest.mock('axios');

describe('AddVehicle', () => {
  it('submits form and displays response', async () => {
    render(<AddVehicle />);
    const image = screen.getByTestId("image");
    const name = screen.getByTestId("name");
    const price = screen.getByTestId("price");
    const mileage = screen.getByTestId("mileage");
    const color = screen.getByTestId("color");
    const seats = screen.getByTestId("seats");
    const fuel = screen.getByTestId("fuel");
    const gear = screen.getByTestId("gear");
    const description = screen.getByTestId("description");

    fireEvent.change(image, { target: { value: '1' } });
    fireEvent.change(name, { target: { value: '1' } });
    fireEvent.change(price, { target: { value: '1' } });
    fireEvent.change(mileage, { target: { value: '1' } });
    fireEvent.change(color, { target: { value: '1' } });
    fireEvent.change(seats, { target: { value: '1' } });
    fireEvent.change(fuel, { target: { value: '1' } });
    fireEvent.change(gear, { target: { value: '1' } });
    fireEvent.change(description, { target: { value: '1' } });


    const mockedData = {
      "name": "asd",
      "image": "sd",
      "mileage": 123,
      "seats": 1,
      "fuelType": "123",
      "gearType": "123",
      "description": "123",
      "price": 12
    }; // Define the mocked data

    axios.post.mockResolvedValueOnce({ data: mockedData }); // Mock Axios post to resolve with the mocked data

    //fireEvent.click(screen.getByTestId('add-button')); // Trigger form submission
    const addBtn = screen.getByTestId("add-btn");
    fireEvent.click(addBtn);

    // Wait for the response to be displayed
    await waitFor(() => {
      //expect(getByText("success")).toBeInTheDocument();
      const spanElement = screen.getByTestId('response');
      expect(spanElement.innerHTML).toBe('success');
    });
  });

});