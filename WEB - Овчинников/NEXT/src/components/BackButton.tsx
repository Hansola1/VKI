import Link from 'next/link';

interface BackButtonProps {
  href: string;
  label?: string;
}

const BackButton = ({ href, label = 'Назадть' }: BackButtonProps) => {
  return (
    <Link
      href={href}
      style={{
        display: 'inline-block',
        marginBottom: '1rem',
        padding: '0.5rem 1rem',
        borderRadius: '4px',
        textDecoration: 'none',
        color: '#ffffffff',
        fontWeight: 'bold',
      }}
    >
      {label}
    </Link>
  );
};

export default BackButton;