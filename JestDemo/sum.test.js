const sum = require('./index');

test('add two numbers together', () => {
    expect(sum(5, 10)).toBe(15)
});