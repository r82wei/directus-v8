<?php

declare(strict_types=1);

namespace Directus\Tests\Core;

use Directus\Core\Options\Exception\EmptySchema;
use Directus\Core\Options\Exception\InvalidOption;
use Directus\Core\Options\Options;
use Directus\Tests\Helpers\DirectusTestCase;

/**
 * Options tests.
 *
 * @internal
 * @coversNothing
 */
final class OptionsTest extends DirectusTestCase
{
    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::__construct
     */
    public function testFailToCreateWithEmptySchema(): void
    {
        $this->expectException(EmptySchema::class);
        new Options([]);
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testCreateWithStringProps(): void
    {
        $options = new Options(['var1', 'var2'], [
            'var1' => 'hello',
            'var2' => 'world',
        ]);

        static::assertSame($options->get('var1'), 'hello');
        static::assertSame($options->get('var2'), 'world');
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testCreateWithComplexProps(): void
    {
        $options = new Options([
            'var1' => [],
            'var2' => [],
        ], [
            'var1' => 'hello',
            'var2' => 'world',
        ]);

        static::assertSame($options->get('var1'), 'hello');
        static::assertSame($options->get('var2'), 'world');
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testCreateWithMixedProps(): void
    {
        $options = new Options([
            'var1',
            'var2' => [],
        ], [
            'var1' => 'hello',
            'var2' => 'world',
        ]);

        static::assertSame($options->get('var1'), 'hello');
        static::assertSame($options->get('var2'), 'world');
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testOptionalParameters(): void
    {
        $options = new Options([
            'var1',
            'var2' => [
                'default' => 'worldssss',
            ],
        ], [
            'var1' => 'hello',
        ]);

        static::assertSame($options->get('var1'), 'hello');
        static::assertSame($options->get('var2'), 'worldssss');
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testOptionalImmediateDefaultParameters(): void
    {
        $options = new Options([
            'var1' => 12345,
            'var2' => 'default_value',
        ], []);

        static::assertSame($options->get('var1'), 12345);
        static::assertSame($options->get('var2'), 'default_value');
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testDefaultValue(): void
    {
        $options = new Options([
            'var' => [
                'default' => 'hello',
            ],
        ], []);

        static::assertSame('hello', $options->get('var'));
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testValueValidation(): void
    {
        $this->expectException(InvalidOption::class);

        new Options([
            'var' => [
                'validate' => 'is_integer',
            ],
        ], [
            'var' => 'hello',
        ]);
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testValueConversion(): void
    {
        $options = new Options([
            'var1' => [
                'convert' => 'intval',
            ],
            'var2' => [
                'convert' => 'strval',
            ],
        ], [
            'var1' => '12345',
            'var2' => 12345,
        ]);

        static::assertIsInt($options->get('var1'));
        static::assertIsString($options->get('var2'));
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testDefaultValueConversion(): void
    {
        $options = new Options([
            'var' => [
                'default' => '12345',
                'convert' => 'intval',
            ],
        ], []);

        static::assertSame(12345, $options->get('var'));
        static::assertIsInt($options->get('var'));
    }

    /**
     * Test option creation.
     *
     * @covers \Directus\Core\Options\Options::feed
     */
    public function testSubPropertyAccess(): void
    {
        $options = new Options([
            'parent.child1',
            'parent.child2',
            'parent.child3.child1',
        ], [
            'parent' => [
                'child1' => 1234,
                'child2' => 4321,
                'child3' => [
                    'child1' => 1111,
                ],
            ],
        ]);

        static::assertSame(1234, $options->get('parent.child1'));
        static::assertSame(4321, $options->get('parent.child2'));
        static::assertSame(1111, $options->get('parent.child3.child1'));
    }
}